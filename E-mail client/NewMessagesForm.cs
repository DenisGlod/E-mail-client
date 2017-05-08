using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_mail_client
{
    public partial class NewMessagesForm : Form
    {
        private ClientProfile _clientProfile;
        public NewMessagesForm(ClientProfile clientProfile)
        {
            InitializeComponent();
            _clientProfile = clientProfile;
        }

        private void Send_Click(object sender, EventArgs e)
        {

        }

        private void LnkAddAttachments_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dr = openFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string[] files = openFileDialog.SafeFileNames;
                if (files.Length > 0)
                {
                    StringBuilder sb = new StringBuilder();
                    files.ToList().ForEach(i =>
                    {
                        if (i.Equals(files[files.Length - 1]))
                        {
                            sb.Append(i);
                        }
                        else
                        {
                            sb.Append(i).Append(", ");

                        }
                    });
                    lnkAddAttachments.Text = sb.ToString();
                }
            }
        }
    }
}
