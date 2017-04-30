using MailKit;
using MailKit.Search;
using MimeKit;
using System;
using System.Collections.Generic;
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
                        if (((TreeNode)i.Current).Text.Equals(f.ParentFolder.Name))
                        {
                            TreeNode node = ((TreeNode)i.Current).Nodes.Add(f.Name);
                            VisibleLinkLable(f, node);
                        }
                    }
                }
                else
                {
                    TreeNode node = treeViewFolder.Nodes.Add(f.Name);
                    VisibleLinkLable(f, node);
                }
            });
        }

        private void VisibleLinkLable(IMailFolder folder, TreeNode node)
        {
            //Console.WriteLine(folder.Attributes.GetHashCode() + " | " + folder.Attributes.ToString() + ", " + folder.Name);
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

        private void LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
            LinkLabel link = (LinkLabel)sender;
            _key.TryGetValue(link, out TreeNode node);
            treeViewFolder.SelectedNode = node;
            treeViewFolder.Focus();
            link.Font = new Font(link.Font, FontStyle.Bold);
        }

        private async void TreeViewFolder_AfterSelect(object sender, TreeViewEventArgs e)
        {
            dgvMessages.Columns.Clear();
            dgvMessages.Columns[dgvMessages.Columns.Add("uid", "uid")].Visible = false;
            dgvMessages.Columns.Add("theme", "Тема");
            dgvMessages.Columns.Add("status", "Статус");
            dgvMessages.Columns[2].Width = 100;
            if (!_clientProfile.Client.IsConnected || !_clientProfile.Client.IsAuthenticated)
            {
                _clientProfile.Reconnect();
            }
            if (!Regex.Match(treeViewFolder.SelectedNode.Text, @"\[.*\]").Success && !_token.CanBeCanceled)
            {
                treeViewFolder.Enabled = false;
                picDownload.Visible = true;
                foreach (IMailFolder f in _folders)
                {
                    if (Regex.IsMatch(f.FullName, e.Node.Text))
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

                        int indexRow = !_token.IsCancellationRequested ? dgvMessages.Rows.Add(new object[] { uid, subject, messageListNotSeen.Contains(uid) ? "Новое" : "Прочитано" }) : 0;
                        if (!_token.IsCancellationRequested && dgvMessages.Rows[indexRow].Cells[2].Value.Equals("Новое"))
                        {
                            dgvMessages.Rows[indexRow].Cells[2].Style.ForeColor = Color.Green;
                            dgvMessages.Rows[indexRow].Cells[2].Style.Font = new Font(dgvMessages.RowTemplate.DefaultCellStyle.Font, FontStyle.Bold);
                        }
                    }
                }
                if (!_token.IsCancellationRequested) _openFolder.Close();
                picDownload.Visible = false;
                treeViewFolder.Enabled = true;
            }
        }

        private async void DgvMessages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            labelAttachments.Visible = false;
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
                        labelTo.Text = string.Join("", "От: ", summary.Envelope.To);
                        if (summary.HtmlBody.IsHtml)
                        {
                            var body = (TextPart)await _openFolder.GetBodyPartAsync(messageUid, summary.HtmlBody, _token);
                            webBrowser.DocumentText = body.Text;
                        }
                        else
                        {
                            var body = (TextPart)await _openFolder.GetBodyPartAsync(messageUid, summary.TextBody, _token);
                            webBrowser.DocumentText = body.Text;
                        }
                        if (summary.Attachments.Count() > 0)
                        {
                            var str = summary.Body.ContentType;
                            labelAttachments.Visible = true;
                            _attachments = summary;
                        }
                        if (((DataGridView)sender).CurrentRow != null && ((DataGridView)sender).CurrentRow.Cells[2].Value.ToString().Equals("Новое"))
                        {
                            ((DataGridView)sender).CurrentRow.Cells[2].Value = "Прочитано";
                            _openFolder.SetFlags(messageUid, MessageFlags.Seen, true);
                            dgvMessages.Rows[e.RowIndex].Cells[2].Style.Font = new Font(dgvMessages.RowTemplate.DefaultCellStyle.Font, FontStyle.Regular);
                            dgvMessages.Rows[e.RowIndex].Cells[2].Style.ForeColor = Color.Black;
                        }
                    }
                }
            }
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;

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
    }
}
