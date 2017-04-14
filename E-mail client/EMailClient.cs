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
            this.client = client;
            labelNameEmail.Text = email;
            client.Behavior.FolderTreeBrowseMode = FolderTreeBrowseMode.Lazy;
            CommonFolderCollection listFolders = client.Folders;
            foreach (Folder folder in listFolders)
            {
                if (folder != client.Folders.Inbox &&
                    folder != client.Folders.Sent &&
                    folder != client.Folders.Drafts &&
                    folder != client.Folders.Junk &&
                    folder != client.Folders.Trash)
                {
                    TreeNode parentNode = treeViewFolder.Nodes.Add(folder.Name);
                    
                    if (folder.HasChildren)
                    {
                        AddTreeViewFolder(folder.SubFolders, parentNode);
                    }
                }
            }

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
    }
}
