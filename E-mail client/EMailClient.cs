using ImapX;
using ImapX.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace E_mail_client
{
    public partial class EMailClient : Form
    {
        private ImapClient _client;
        private Dictionary<LinkLabel, TreeNode> _key;
        private List<ImapX.Message> _messageList;

        public EMailClient(ImapClient client, string email)
        {
            InitializeComponent();
            treeViewFolder.HideSelection = false;
            panelFolders.Height = 0;
            _client = client;
            labelNameEmail.Text = email;
            client.Behavior.AutoPopulateFolderMessages = true;
            CommonFolderCollection listFolders = client.Folders;
            _key = new Dictionary<LinkLabel, TreeNode>();
            foreach (Folder folder in listFolders)
            {
                TreeNode parentNode = treeViewFolder.Nodes.Add(folder.Name);
                VisibleLinkLable(folder, parentNode);
                if (folder.HasChildren)
                {
                    AddTreeViewFolder(folder.SubFolders, parentNode);
                }
            }
        }

        private bool VisibleLinkLable(Folder folder, TreeNode node)
        {
            if (folder == _client.Folders.Inbox)
            {
                lnkInbox.Visible = true;
                panelFolders.Height += 27;
                _key.Add(lnkInbox, node);
                return false;
            }
            if (folder == _client.Folders.Sent)
            {
                lnkSent.Visible = true;
                panelFolders.Height += 27;
                _key.Add(lnkSent, node);
                return false;
            }
            if (folder == _client.Folders.Drafts)
            {
                lnkDrafts.Visible = true;
                panelFolders.Height += 27;
                _key.Add(lnkDrafts, node);
                return false;
            }
            if (folder == _client.Folders.Important)
            {
                lnkImportant.Visible = true;
                panelFolders.Height += 27;
                _key.Add(lnkImportant, node);
                return false;
            }
            if (folder == _client.Folders.Flagged)
            {
                lnkFlagged.Visible = true;
                panelFolders.Height += 27;
                _key.Add(lnkFlagged, node);
                return false;
            }
            if (folder == _client.Folders.Junk)
            {
                lnkJunk.Visible = true;
                panelFolders.Height += 27;
                _key.Add(lnkJunk, node);
                return false;
            }
            if (folder == _client.Folders.Trash)
            {
                lnkTrash.Visible = true;
                panelFolders.Height += 27;
                _key.Add(lnkTrash, node);
                return false;
            }
            if (folder == _client.Folders.All)
            {
                lnkAll.Visible = true;
                panelFolders.Height += 27;
                _key.Add(lnkAll, node);
                return false;
            }
            if (folder == _client.Folders.Archive)
            {
                lnkArchive.Visible = true;
                panelFolders.Height += 27;
                _key.Add(lnkArchive, node);
                return false;
            }
            return true;
        }

        private void AddTreeViewFolder(FolderCollection folders, TreeNode parentNode)
        {
            foreach (Folder folder in folders)
            {
                TreeNode childNode = parentNode.Nodes.Add(folder.Name);
                if (folder.HasChildren)
                {
                    AddTreeViewFolder(folder.SubFolders, childNode);
                }
            }
        }

        private void FormClose(object sender, FormClosingEventArgs e)
        {
            _client.Disconnect();
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
            link.Font = new Font(link.Font, FontStyle.Bold);
        }

        private void TreeViewFolder_AfterSelect(object sender, TreeViewEventArgs e)
        {
            dgvMessages.Columns.Clear();
            dgvMessages.Columns.Add("from", "От");
            dgvMessages.Columns.Add("theme", "Тема");
            dgvMessages.Columns.Add("status", "Статус");
            if (treeViewFolder.Focus())
            {
                var folder = _client.Folders.Find(treeViewFolder.SelectedNode.Text);

                if (folder != null)
                {
                    _messageList = new List<ImapX.Message>();
                    _messageList.InsertRange(0, folder.Messages);
                    var iMessage = _messageList.GetEnumerator();
                    while (iMessage.MoveNext())
                    {
                        if (iMessage.Current != null)
                        {
                            dgvMessages.Rows.Add(new object[] { iMessage.Current.From, iMessage.Current.Subject, iMessage.Current.Seen ? "Просмотрено" : "Новое" });
                        }
                    }
                }
            }
        }

        private void dgvMessages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                labelDate.Text = string.Join("", "Дата: ", _messageList[e.RowIndex].Date.ToString());
                labelTheme.Text = string.Join("", "Тема: ", _messageList[e.RowIndex].Subject);
                labelFrom.Text = string.Join("", "От: ", _messageList[e.RowIndex].From);
                string _to = "Кому: ";
                _messageList[e.RowIndex].To.ForEach(delegate (MailAddress m) { _to += string.Join(" ", m); });
                labelTo.Text = _to;
                MessageBody body = _messageList[e.RowIndex].Body;
                if (body.HasHtml)
                {
                    int i = body.Html.LastIndexOf("IMAPX");
                    webBrowser.DocumentText = body.Html.Remove(i - 3, 34);
                }
                else
                {
                    int i = body.Text.LastIndexOf("IMAPX");
                    webBrowser.DocumentText = body.Text.Remove(i - 3, 34);
                }
            }
        }
    }
}
