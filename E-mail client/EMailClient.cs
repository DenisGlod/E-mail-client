using ImapX;
using ImapX.Collections;
using ImapX.Enums;
using System.Windows.Forms;

namespace E_mail_client
{
    public partial class EMailClient : Form
    {
        private ImapClient client;
        public EMailClient(ImapClient client, string email)
        {
            InitializeComponent();
            panelFolders.Height = 0;
            this.client = client;
            labelNameEmail.Text = email;
            client.Behavior.FolderTreeBrowseMode = FolderTreeBrowseMode.Lazy;
            CommonFolderCollection listFolders = client.Folders;
            foreach (Folder folder in listFolders)
            {
                if (VisibleLinkLable(folder))
                {
                    TreeNode parentNode = treeViewFolder.Nodes.Add(folder.Name);
                    if (folder.HasChildren)
                    {
                        AddTreeViewFolder(folder.SubFolders, parentNode);
                    }
                }
            }

        }
        private bool VisibleLinkLable(Folder folder)
        {
            if (folder == client.Folders.Inbox)
            {
                linkLabelInbox.Visible = true;
                panelFolders.Height += 27;
                return false;
            }
            if (folder == client.Folders.Sent)
            {
                linkLabelSent.Visible = true;
                panelFolders.Height += 27;
                return false;
            }
            if (folder == client.Folders.Drafts)
            {
                linkLabelDrafts.Visible = true;
                panelFolders.Height += 27;
                return false;
            }
            if (folder == client.Folders.Important)
            {
                linkLabelImportant.Visible = true;
                panelFolders.Height += 27;
                return false;
            }
            if (folder == client.Folders.Flagged)
            {
                linkLabelFlagged.Visible = true;
                panelFolders.Height += 27;
                return false;
            }
            if (folder == client.Folders.Junk)
            {
                linkLabelJunk.Visible = true;
                panelFolders.Height += 27;
                return false;
            }
            if (folder == client.Folders.Trash)
            {
                linkLabelTrash.Visible = true;
                panelFolders.Height += 27;
                return false;
            }
            if (folder == client.Folders.All)
            {
                linkLabelAll.Visible = true;
                panelFolders.Height += 27;
                return false;
            }
            if (folder == client.Folders.Archive)
            {
                linkLabelArchive.Visible = true;
                panelFolders.Height += 27;
                return false;
            }
            return true;
        }
        //folder.Messages.Download();
        //IEnumerator<ImapX.Message> messageList = folder.Messages.GetEnumerator();
        //while (messageList.MoveNext())
        //{
        //    if (messageList.Current != null)
        //    {
        //        Console.WriteLine(messageList.Current.Date.Value.ToString());
        //        Console.WriteLine(messageList.Current.Subject);
        //        Console.WriteLine(messageList.Current.Body.Html);
        //    }
        //}
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
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
