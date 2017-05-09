using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace E_mail_client
{
    public partial class ClientForm : Form
    {
        private ClientProfile _clientProfile;
        private Dictionary<LinkLabel, TreeNode> _key = new Dictionary<LinkLabel, TreeNode>();
        private IMailFolder _openFolder;
        private IList<IMailFolder> _folders;
        private TransferProgress _tProgress = new TransferProgress();
        private CancellationToken _token = new CancellationToken(false);
        private IList<IMessageSummary> _listMessageSummary;
        private IMessageSummary _attachments;
        private string _directory;
        private ComponentResourceManager resources = new ComponentResourceManager(typeof(ClientForm));
        private const string _cellStatus = "status";

        public ClientForm(ClientProfile clientProfile)
        {
            InitializeComponent();
            panelFolders.Height = 0;
            _clientProfile = clientProfile;
            labelNameEmail.Text = _clientProfile.Email;
            InitFolders();
            webBrowser.Dock = DockStyle.Fill;
            _directory = AppDomain.CurrentDomain.BaseDirectory + "\\temp";
            _tProgress.ProgressChanged += (s, percent) =>
            {
                BeginInvoke((MethodInvoker)(() =>
                    {
                        labelAttachments.Text = "Загрузка: " + (int)percent + " %";
                    }));
            };
        }

        private async void InitFolders()
        {
            _folders = await _clientProfile.Client.GetFoldersAsync(_clientProfile.Client.PersonalNamespaces.First(), false, _token);
            _folders.ToList().ForEach(f =>
            {
                if (!f.ParentFolder.Name.Equals(""))
                {
                    var i = treeViewFolder.Nodes.GetEnumerator();
                    while (i.MoveNext())
                    {
                        if (((TreeNode)i.Current).Text.Trim().Equals(f.ParentFolder.Name))
                        {
                            TreeNode node = ((TreeNode)i.Current).Nodes.Add(f.Name + "    ");
                            VisibleLinkLable(f, node);
                        }
                    }
                }
                else
                {
                    TreeNode node = treeViewFolder.Nodes.Add(f.Name + "    ");
                    VisibleLinkLable(f, node);
                }
            });
        }

        private void VisibleLinkLable(IMailFolder folder, TreeNode node)
        {
            if (folder.Attributes.HasFlag(FolderAttributes.NonExistent))
            {
                return;
            }
            if (folder.Attributes.HasFlag(FolderAttributes.Inbox))
            {
                lnkInbox.Visible = true;
                panelFolders.Height += 27;
                _key.Add(lnkInbox, node);
                return;
            }
            if (folder.Attributes.HasFlag(FolderAttributes.Sent))
            {
                lnkSent.Visible = true;
                panelFolders.Height += 27;
                _key.Add(lnkSent, node);
                return;
            }
            if (folder.Attributes.HasFlag(FolderAttributes.Drafts))
            {
                lnkDrafts.Visible = true;
                panelFolders.Height += 27;
                _key.Add(lnkDrafts, node);
                return;
            }
            if (folder.Attributes.HasFlag(FolderAttributes.Flagged))
            {
                lnkFlagged.Visible = true;
                panelFolders.Height += 27;
                _key.Add(lnkFlagged, node);
                return;
            }
            if (folder.Attributes.HasFlag(FolderAttributes.Junk))
            {
                lnkJunk.Visible = true;
                panelFolders.Height += 27;
                _key.Add(lnkJunk, node);
                return;
            }
            if (folder.Attributes.HasFlag(FolderAttributes.Trash))
            {
                lnkTrash.Visible = true;
                panelFolders.Height += 27;
                _key.Add(lnkTrash, node);
                return;
            }
            if (folder.Attributes.HasFlag(FolderAttributes.All))
            {
                lnkAll.Visible = true;
                panelFolders.Height += 27;
                _key.Add(lnkAll, node);
                return;
            }
            if (folder.Attributes.HasFlag(FolderAttributes.Archive))
            {
                lnkArchive.Visible = true;
                panelFolders.Height += 27;
                _key.Add(lnkArchive, node);
                return;
            }
            if (folder.Name.ToLower().Equals("важное"))
            {
                lnkImportant.Visible = true;
                panelFolders.Height += 27;
                _key.Add(lnkImportant, node);
                return;
            }
        }

        private void FormClose(object sender, FormClosingEventArgs e)
        {
            lock (_clientProfile.Client.SyncRoot)
            {
                _token = new CancellationToken(true);
                if (_clientProfile.Client.IsConnected)
                {
                    _clientProfile.Client.Disconnect(true);
                }
            }
            Application.Exit();
        }

        #region Событие LinkClicked которое происходит по нажатию на все LinkLabel
        private void LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkDefaultFont();
            LinkLabel link = (LinkLabel)sender;
            _key.TryGetValue(link, out TreeNode node);
            treeViewFolder.SelectedNode = node;
            link.Font = new Font(link.Font, FontStyle.Bold);
        }
        #endregion

        private void TreeViewFolder_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (treeViewFolder.SelectedNode != null)
            {
                treeViewFolder.SelectedNode.NodeFont = new Font(treeViewFolder.Font, FontStyle.Regular);
            }
        }

        private async void TreeViewFolder_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ClietnReconnect();
            ViewMessageClear();
            LinkLock();
            treeViewFolder.SelectedNode.NodeFont = new Font(treeViewFolder.Font, FontStyle.Bold);
            dgvMessages.Columns.Clear();
            dgvMessages.Columns[dgvMessages.Columns.Add("uid", "uid")].Visible = false;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn()
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 30
            };
            dgvMessages.Columns.Add(imageColumn);
            dgvMessages.Columns.Add("theme", "Тема");
            dgvMessages.Columns.Add("status", "Статус");
            dgvMessages.Columns[3].Width = 100;
            if (!Regex.Match(treeViewFolder.SelectedNode.Text, @"\[.*\]").Success && !_token.CanBeCanceled)
            {
                treeViewFolder.Enabled = false;
                picDownload.Visible = true;
                foreach (IMailFolder f in _folders)
                {
                    if (Regex.IsMatch(f.FullName, e.Node.Text.Trim()))
                    {
                        _openFolder = f;
                        break;
                    }
                }
                await _openFolder.OpenAsync(FolderAccess.ReadOnly, _token);
                var _uidsListMessages = (await _openFolder.SearchAsync(SearchQuery.All, _token)).ToList();

                if (_uidsListMessages.Count > 0)
                {
                    var messageListNotSeen = (await _openFolder.SearchAsync(SearchQuery.NotSeen, _token)).ToList();
                    _listMessageSummary = await _openFolder.FetchAsync(_uidsListMessages, MessageSummaryItems.UniqueId | MessageSummaryItems.BodyStructure | MessageSummaryItems.Full, _token);
                    foreach (IMessageSummary summary in _listMessageSummary)
                    {
                        string subject = summary.Envelope.Subject;
                        UniqueId uid = summary.UniqueId;

                        int indexRow = !_token.IsCancellationRequested ? dgvMessages.Rows.Add(new object[] {
                            uid,
                            summary.Attachments.Count() > 0 ? Properties.Resources.attach : Properties.Resources.white,
                            subject,
                            messageListNotSeen.Contains(uid) ? "Новое" : "Прочитано"
                        }) : 0;
                        if (!_token.IsCancellationRequested && dgvMessages.Rows[indexRow].Cells[_cellStatus].Value.Equals("Новое"))
                        {
                            dgvMessages.Rows[indexRow].Cells[_cellStatus].Style.ForeColor = Color.Green;
                            dgvMessages.Rows[indexRow].Cells[_cellStatus].Style.Font = new Font(dgvMessages.RowTemplate.DefaultCellStyle.Font, FontStyle.Bold);
                        }
                    }
                }
                if (!_token.IsCancellationRequested) _openFolder.Close();
                picDownload.Visible = false;
                treeViewFolder.Enabled = true;
                LinkActive();
            }
        }

        private async void DgvMessages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClietnReconnect();
            treeViewFolder.Enabled = false;
            // dgvMessages.Enabled = false;
            // panelButton.Enabled = false;
            LinkLock();
            labelAttachments.Visible = false;
            labelAttachments.Text = "Скачать вложения";
            if (e.RowIndex > -1)
            {
                await _openFolder.OpenAsync(FolderAccess.ReadWrite, _token);
                var messageUid = UniqueId.Parse(((DataGridView)sender).CurrentRow.Cells[0].Value.ToString());

                if (Directory.Exists(_directory + "\\" + messageUid.ToString()) && Directory.GetFiles(_directory + "\\" + messageUid.ToString()).Length > 0)
                {
                    labelAttachments.Text = "Открыть вложения";
                }
                foreach (var summary in _listMessageSummary)
                {
                    if (summary.UniqueId == messageUid)
                    {
                        labelDate.Text = string.Join("", "Дата: ", summary.Date.DateTime);
                        labelTheme.Text = string.Join("", "Тема: ", summary.Envelope.Subject);
                        labelFrom.Text = string.Join("", "От: ", summary.Envelope.From);
                        labelTo.Text = string.Join("", "Кому: ", summary.Envelope.To);
                        if (summary.HtmlBody != null && summary.HtmlBody.IsHtml)
                        {
                            var body = (TextPart)await _openFolder.GetBodyPartAsync(messageUid, summary.HtmlBody, _token);
                            webBrowser.DocumentText = body.Text;
                        }
                        else
                        {
                            var body = (TextPart)await _openFolder.GetBodyPartAsync(messageUid, summary.TextBody, _token);
                            webBrowser.DocumentText = body.Text.Replace("\r\n", "<br>");
                        }
                        if (summary.Attachments.Count() > 0)
                        {
                            labelAttachments.Visible = true;
                            labelAttachments.Height = 30;
                            _attachments = summary;
                        }
                        if (((DataGridView)sender).CurrentRow != null && ((DataGridView)sender).CurrentRow.Cells[_cellStatus].Value.ToString().Equals("Новое"))
                        {
                            ((DataGridView)sender).CurrentRow.Cells[_cellStatus].Value = "Прочитано";
                            _openFolder.SetFlags(messageUid, MessageFlags.Seen, true);
                            dgvMessages.Rows[e.RowIndex].Cells[_cellStatus].Style.Font = new Font(dgvMessages.RowTemplate.DefaultCellStyle.Font, FontStyle.Regular);
                            dgvMessages.Rows[e.RowIndex].Cells[_cellStatus].Style.ForeColor = Color.Black;
                        }
                    }
                }
            }
            LinkActive();
            // panelButton.Enabled = true;
            // dgvMessages.Enabled = true;
            treeViewFolder.Enabled = true;
        }

        private void LabelAttachments_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string directory = Path.Combine(_directory, _attachments.UniqueId.ToString());
            if (!Directory.Exists(directory))
            {
                DownloadAttachments(directory);
            }
            else if (Directory.GetFiles(directory).Length < _attachments.Attachments.Count())
            {
                DownloadAttachments(directory);
            }
            else
            {
                Process.Start(_directory + "\\" + _attachments.UniqueId.ToString());
            }
        }

        private void TreeViewFolder_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            LinkDefaultFont();
            _key.ToList().ForEach((k) =>
            {
                if (k.Value == e.Node)
                {
                    k.Key.Font = new Font(lnkAll.Font, FontStyle.Bold);
                    return;
                }

            });
        }

        private async void ButtonDeleteMessage_Click(object sender, EventArgs e)
        {
            if (!_openFolder.Attributes.HasFlag(FolderAttributes.Trash))
            {
                if (dgvMessages.SelectedRows.Count > 0)
                {
                    var result = MessageBox.Show("Вы точно хотите переместить сообщение в козину?", "Удаление сообщение", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        var cells = dgvMessages.SelectedCells.GetEnumerator();
                        cells.MoveNext();
                        var uid = (UniqueId)((DataGridViewTextBoxCell)cells.Current).Value;
                        await _openFolder.OpenAsync(FolderAccess.ReadWrite, _token);
                        IMailFolder trash = null;
                        _folders.ToList().ForEach(folder =>
                        {
                            if (folder.Attributes.HasFlag(FolderAttributes.Trash))
                            {
                                trash = folder;
                            }
                        });
                        await _openFolder.MoveToAsync(uid, trash, _token);
                        dgvMessages.Rows.Remove(dgvMessages.CurrentRow);
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка! Не выбрано сообщение для перемещения в корзину!", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                var result = MessageBox.Show("Вы точно хотите полностью УДАЛИТЬ сообщение?", "Удаление сообщение", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    var cells = dgvMessages.SelectedCells.GetEnumerator();
                    cells.MoveNext();
                    var uid = (UniqueId)((DataGridViewTextBoxCell)cells.Current).Value;
                    await _openFolder.OpenAsync(FolderAccess.ReadWrite, _token);
                    await _openFolder.AddFlagsAsync(uid, MessageFlags.Deleted, false, _token);
                    if (_clientProfile.Client.Capabilities.HasFlag(ImapCapabilities.UidPlus))
                    {
                        await _openFolder.ExpungeAsync(new UniqueId[] { uid });
                        dgvMessages.Rows.Remove(dgvMessages.CurrentRow);
                    }
                }
            }
            ViewMessageClear();
        }

        private async void DownloadAttachments(string directory)
        {
            labelAttachments.Enabled = false;

            Directory.CreateDirectory(directory);
            foreach (var attachment in _attachments.Attachments)
            {
                // download the attachment just like we did with the body
                var entity = await _openFolder.GetBodyPartAsync(_attachments.UniqueId, attachment, _token, _tProgress);

                // attachments can be either message/rfc822 parts or regular MIME parts

                var part = (MimePart)entity;

                // note: it's possible for this to be null, but most will specify a filename
                var fileName = part.FileName;

                var path = Path.Combine(directory, fileName);

                // decode and save the content to a file
                using (var stream = File.Create(path))
                    part.ContentObject.DecodeTo(stream);
                labelAttachments.Enabled = true;
                labelAttachments.Text = "Открыть вложения";
            }
        }

        private void LinkDefaultFont()
        {
            lnkAll.Font =
                lnkArchive.Font =
                lnkDrafts.Font =
                lnkFlagged.Font =
                lnkImportant.Font =
                lnkInbox.Font =
                lnkJunk.Font =
                lnkSent.Font =
                lnkTrash.Font = new Font(lnkTrash.Font, FontStyle.Regular);
        }

        private void LinkLock()
        {
            lnkAll.Enabled =
                lnkArchive.Enabled =
                lnkDrafts.Enabled =
                lnkFlagged.Enabled =
                lnkImportant.Enabled =
                lnkInbox.Enabled =
                lnkJunk.Enabled =
                lnkSent.Enabled =
                lnkTrash.Enabled = false;
        }

        private void LinkActive()
        {
            lnkAll.Enabled =
                lnkArchive.Enabled =
                lnkDrafts.Enabled =
                lnkFlagged.Enabled =
                lnkImportant.Enabled =
                lnkInbox.Enabled =
                lnkJunk.Enabled =
                lnkSent.Enabled =
                lnkTrash.Enabled = true;
        }

        private void ViewMessageClear()
        {
            labelDate.Text = "Дата: ";
            labelTheme.Text = "Тема: ";
            labelFrom.Text = "От: ";
            labelTo.Text = "Кому: ";
            webBrowser.DocumentText = "";
        }

        private void ClietnReconnect()
        {
            if (!_clientProfile.Client.IsConnected || !_clientProfile.Client.IsAuthenticated)
            {
                _clientProfile.Reconnect();
            }
        }

        private void ButtonNewMessage_Click(object sender, EventArgs e)
        {
            new NewMessagesForm(_clientProfile).Visible = true;
        }

        private void dgvMessages_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            buttonDeleteMessage.Enabled = true;
        }

        private void dgvMessages_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            buttonDeleteMessage.Enabled = false;
        }
    }
}
