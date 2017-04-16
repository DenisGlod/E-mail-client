using ImapX;
using ImapX.Collections;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace E_mail_client
{
    public partial class EMailClient : Form
    {
        private ImapClient client;
        private Dictionary<LinkLabel, TreeNode> key;

        public EMailClient(ImapClient client, string email)
        {
            InitializeComponent();
            treeViewFolder.HideSelection = false;
            panelFolders.Height = 0;
            this.client = client;
            labelNameEmail.Text = email;
            client.Behavior.AutoPopulateFolderMessages = true;
            CommonFolderCollection listFolders = client.Folders;
            key = new Dictionary<LinkLabel, TreeNode>();
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
            if (folder == client.Folders.Inbox)
            {
                lnkInbox.Visible = true;
                panelFolders.Height += 27;
                key.Add(lnkInbox, node);
                return false;
            }
            if (folder == client.Folders.Sent)
            {
                lnkSent.Visible = true;
                panelFolders.Height += 27;
                key.Add(lnkSent, node);
                return false;
            }
            if (folder == client.Folders.Drafts)
            {
                lnkDrafts.Visible = true;
                panelFolders.Height += 27;
                key.Add(lnkDrafts, node);
                return false;
            }
            if (folder == client.Folders.Important)
            {
                lnkImportant.Visible = true;
                panelFolders.Height += 27;
                key.Add(lnkImportant, node);
                return false;
            }
            if (folder == client.Folders.Flagged)
            {
                lnkFlagged.Visible = true;
                panelFolders.Height += 27;
                key.Add(lnkFlagged, node);
                return false;
            }
            if (folder == client.Folders.Junk)
            {
                lnkJunk.Visible = true;
                panelFolders.Height += 27;
                key.Add(lnkJunk, node);
                return false;
            }
            if (folder == client.Folders.Trash)
            {
                lnkTrash.Visible = true;
                panelFolders.Height += 27;
                key.Add(lnkTrash, node);
                return false;
            }
            if (folder == client.Folders.All)
            {
                lnkAll.Visible = true;
                panelFolders.Height += 27;
                key.Add(lnkAll, node);
                return false;
            }
            if (folder == client.Folders.Archive)
            {
                lnkArchive.Visible = true;
                panelFolders.Height += 27;
                key.Add(lnkArchive, node);
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
            client.Disconnect();
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
            key.TryGetValue(link, out TreeNode node);
            treeViewFolder.SelectedNode = node;
            link.Font = new Font(link.Font, FontStyle.Bold);
        }

        private void treeViewFolder_AfterSelect(object sender, TreeViewEventArgs e)
        {
            dgvMessages.Columns.Clear();
            dgvMessages.Columns.Add("from", "От");
            dgvMessages.Columns.Add("theme", "Тема");
            dgvMessages.Columns.Add("status", "Статус");
            if (treeViewFolder.Focus())
            {
                var folder = client.Folders.Find(treeViewFolder.SelectedNode.Text);

                if (folder != null)
                {
                    var messageList = folder.Messages;
                    var iMessage = messageList.GetEnumerator();
                    while (iMessage.MoveNext())
                    {
                        if (iMessage.Current != null)
                        {
                            dgvMessages.Rows.Add(new object[] { iMessage.Current.From, iMessage.Current.Subject, iMessage.Current.Seen ? "Просмотрено" : "Новое" });
                            Console.WriteLine(iMessage.Current.Date.Value.ToString());
                            Console.WriteLine(iMessage.Current.Subject);
                        }
                    }
                }
            }
        }
    }
}
