using MailKit;
using MailKit.Search;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace E_mail_client
{
    public partial class ClientForm : Form
    {
        private ClientProfile _clientProfile;
        private Dictionary<LinkLabel, TreeNode> _key;
        private IMailFolder _openFolder;
        private List<UniqueId> _messageList;
        private IList<IMailFolder> _folders;

        public ClientForm(ClientProfile clientProfile)
        {
            InitializeComponent();
            panelFolders.Height = 0;
            _clientProfile = clientProfile;
            labelNameEmail.Text = _clientProfile.Email;
            _key = new Dictionary<LinkLabel, TreeNode>();
            InitFolders();
        }

        private void InitFolders()
        {
            _folders = _clientProfile.Client.GetFolders(_clientProfile.Client.PersonalNamespaces.First());
            _folders.ToList().ForEach(f =>
            {
                if (!f.ParentFolder.Name.Equals(""))
                {
                    var i = treeViewFolder.Nodes.GetEnumerator();
                    while (i.MoveNext())
                    {
                        if (((TreeNode)i.Current).Text.Equals(f.ParentFolder.Name))
                        {
                            ((TreeNode)i.Current).Nodes.Add(f.Name);
                            VisibleLinkLable(f, (TreeNode)i.Current);
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
            _clientProfile.Client.Disconnect(true);
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

        private void TreeViewFolder_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!_clientProfile.Client.IsConnected || !_clientProfile.Client.IsAuthenticated)
            {
                _clientProfile.Reconnect();
            }
            if (Regex.Match(treeViewFolder.SelectedNode.Text, @"\[.*\]").Success)
            {
                return;
            }
            dgvMessages.Columns.Clear();
            dgvMessages.Columns.Add("from", "От");
            dgvMessages.Columns.Add("theme", "Тема");
            dgvMessages.Columns.Add("status", "Статус");
            foreach(IMailFolder f in _folders)
            {
                if(Regex.IsMatch(f.FullName, e.Node.Text))
                {
                    _openFolder = f;
                    break;
                }
            }
            
            _openFolder.Open(FolderAccess.ReadOnly);
            var uids = _openFolder.Search(SearchQuery.All);
            if (uids.Count > 0)
            {
                _messageList = _openFolder.Search(SearchQuery.All).ToList();
                _messageList.ForEach(uid =>
                {
                    MimeMessage mimeMessage = _openFolder.GetMessage(uid);
                    dgvMessages.Rows.Add(new object[] { mimeMessage.From, mimeMessage.Subject, _openFolder.Search(SearchQuery.NotSeen).Contains(uid) ? "Новое" : "Прочитано" });
                });
            }
            _openFolder.Close();
        }

        private void DgvMessages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonDeleteMessage.Enabled = true;
            if (e.RowIndex > -1)
            {
                _openFolder.Open(FolderAccess.ReadOnly);
                labelDate.Text = string.Join("", "Дата: ", _openFolder.GetMessage(_messageList[e.RowIndex]).Date);
                labelTheme.Text = string.Join("", "Тема: ", _openFolder.GetMessage(_messageList[e.RowIndex]).Subject);
                labelFrom.Text = string.Join("", "От: ", _openFolder.GetMessage(_messageList[e.RowIndex]).From);
                string _to = "Кому: ";
                _openFolder.GetMessage(_messageList[e.RowIndex]).To.ToList().ForEach(m => { _to += string.Join(" ", m); });
                labelTo.Text = _to;
                var body = _openFolder.GetMessage(_messageList[e.RowIndex]).Body;
                Console.WriteLine(body.ToString());
            }
        }
    }
}
