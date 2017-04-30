using MailKit;
using MailKit.Search;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        private IList<UniqueId> _uidsListMessages;

        public ClientForm(ClientProfile clientProfile)
        {
            InitializeComponent();
            panelFolders.Height = 0;
            _clientProfile = clientProfile;
            labelNameEmail.Text = _clientProfile.Email;
            InitFolders();
            _tProgress.ProgressChanged += (s, percent) => { BeginInvoke((MethodInvoker)(() => progressBar.Value = (int)percent)); };
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
            //_clientProfile.Client.Disconnect(true);
            //_source.Cancel();
            //_token = _source.Token;
            //Thread.Sleep(2000);
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
            if (!_clientProfile.Client.IsConnected || !_clientProfile.Client.IsAuthenticated)
            {
                _clientProfile.Reconnect();
            }
            if (!Regex.Match(treeViewFolder.SelectedNode.Text, @"\[.*\]").Success && !_token.CanBeCanceled)
            {
                treeViewFolder.Enabled = false;
                picDownload.Visible = true;
                dgvMessages.Columns.Clear();
                int idUid = dgvMessages.Columns.Add("uid", "uid");
                dgvMessages.Columns[idUid].Visible = false;
                dgvMessages.Columns.Add("theme", "Тема");
                dgvMessages.Columns.Add("status", "Статус");
                dgvMessages.Columns[2].Width = 100;
                foreach (IMailFolder f in _folders)
                {
                    if (Regex.IsMatch(f.FullName, e.Node.Text))
                    {
                        _openFolder = f;
                        break;
                    }
                }
                await _openFolder.OpenAsync(FolderAccess.ReadOnly, _token);
                _uidsListMessages = (await _openFolder.SearchAsync(SearchQuery.All, _token)).ToList();
                if (_uidsListMessages.Count > 0)
                {
                    var messageListNotSeen = (await _openFolder.SearchAsync(SearchQuery.NotSeen, _token)).ToList();
                    foreach (UniqueId uid in _uidsListMessages)
                    {
                        HeaderList headerList = await _openFolder.GetHeadersAsync(uid, _token);
                        string subject = "";
                        headerList.ToList().ForEach(h =>
                        {
                            if (h.Id == HeaderId.Subject)
                            {
                                subject = h.Value;
                            }
                        });
                        int indexRow = dgvMessages.Rows.Add(new object[] { uid, subject, messageListNotSeen.Contains(uid) ? "Новое" : "Прочитано" });
                        if (dgvMessages.Rows[indexRow].Cells[2].Value.Equals("Новое"))
                        {
                            dgvMessages.Rows[indexRow].Cells[2].Style.ForeColor = Color.Green;
                            dgvMessages.Rows[indexRow].Cells[2].Style.Font = new Font(dgvMessages.RowTemplate.DefaultCellStyle.Font, FontStyle.Bold);
                        }
                    }
                }
                _openFolder.Close();
                picDownload.Visible = false;
                treeViewFolder.Enabled = true;
            }
        }

        private async void DgvMessages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            labelAttachments.Visible = false;
            progressBar.Value = 0;
            panelDM.Visible = true;
            if (e.RowIndex > -1)
            {
                await _openFolder.OpenAsync(FolderAccess.ReadWrite, _token);
                var messageUid = UniqueId.Parse(((DataGridView)sender).CurrentRow.Cells[0].Value.ToString());

                foreach (var summary in _openFolder.Fetch(_uidsListMessages, MessageSummaryItems.UniqueId | MessageSummaryItems.Body | MessageSummaryItems.All))
                {
                    labelDate.Text = string.Join("", "Дата: ", summary.Date.DateTime);
                    labelTheme.Text = string.Join("", "Тема: ", summary.Envelope.Subject);
                    labelFrom.Text = string.Join("", "От: ", summary.Envelope.From);

                    //Console.WriteLine("UID " + summary.UniqueId);
                    //Console.WriteLine("Body " + summary.Body);
                    //Console.WriteLine("Attachments count " + summary.Attachments.Count());
                    //Console.WriteLine("Subject " + summary.Envelope.Subject);
                    //Console.WriteLine("From " + summary.Envelope.From);
                    //Console.WriteLine("To " + summary.Envelope.To);
                    //Console.WriteLine("Date " + summary.Date.DateTime);

                    if (summary.Body is BodyPartMultipart multipart)
                    {
                        labelAttachments.Visible = true;
                        var attachment = multipart.BodyParts.OfType<BodyPartBasic>().FirstOrDefault(x => labelAttachments.Tex.FileName;);
                        if (attachment != null)
                        {
                            // this will download *just* the attachment
                            var part = inbox.GetBodyPart(summary.UniqueId, attachment);
                        }
                    }

                    if (((DataGridView)sender).CurrentRow.Cells[2].Value.ToString().Equals("Новое"))
                    {
                        ((DataGridView)sender).CurrentRow.Cells[2].Value = "Прочитано";
                        _openFolder.SetFlags(messageUid, MessageFlags.Seen, true);
                        dgvMessages.Rows[e.RowIndex].Cells[2].Style.Font = new Font(dgvMessages.RowTemplate.DefaultCellStyle.Font, FontStyle.Regular);
                        dgvMessages.Rows[e.RowIndex].Cells[2].Style.ForeColor = Color.Black;
                    }
                }

                // var message = await _openFolder.GetBodyPartAsync(messageUid, , _tProgress);



                //labelDate.Text = string.Join("", "Дата: ", message.Date.DateTime);
                //labelTheme.Text = string.Join("", "Тема: ", message.Subject);
                //labelFrom.Text = string.Join("", "От: ", message.From);
                //string to = "Кому: ";
                //message.To.ToList().ForEach(m => { to += string.Join(" ", m); });
                //labelTo.Text = to;
                //string body;
                //if (message.TextBody == null)
                //{
                //    body = message.HtmlBody;
                //}
                //else if (message.HtmlBody == null)
                //{
                //    body = message.TextBody.Replace("\r\n", "<br>");
                //}
                //else
                //{
                //    body = message.HtmlBody;
                //}
                //webBrowser.DocumentText = body;
                //var ienum = message.Attachments.GetEnumerator();
                //if (message.Attachments.ToList().Count() != 0)
                //{
                //    labelAttachments.Visible = true;
                //}
                //if (((DataGridView)sender).CurrentRow.Cells[2].Value.ToString().Equals("Новое"))
                //{
                //    ((DataGridView)sender).CurrentRow.Cells[2].Value = "Прочитано";
                //    _openFolder.SetFlags(messageUid, MessageFlags.Seen, true);
                //    dgvMessages.Rows[e.RowIndex].Cells[2].Style.Font = new Font(dgvMessages.RowTemplate.DefaultCellStyle.Font, FontStyle.Regular);
                //    dgvMessages.Rows[e.RowIndex].Cells[2].Style.ForeColor = Color.Black;
                //}
            }
            panelDM.Visible = false;
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
        }
    }
}
