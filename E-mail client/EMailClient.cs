using System.Windows.Forms;
using ImapX;

namespace E_mail_client
{
    public partial class EMailClient : Form
    {
        private ImapClient client;
        public EMailClient(ImapClient client)
        {
            InitializeComponent();
            this.client = client;
        }

    }
}
