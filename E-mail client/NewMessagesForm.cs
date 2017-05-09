using MimeKit;
using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace E_mail_client
{
    public partial class NewMessagesForm : Form
    {
        private ClientProfile _clientProfile;
        private string[] _attachments;
        public NewMessagesForm(ClientProfile clientProfile)
        {
            InitializeComponent();
            _clientProfile = clientProfile;
        }

        private void Send_Click(object sender, EventArgs e)
        {
            string from = _clientProfile.Email;
            string to = tbTo.Text.Trim();
            string subject = tbSubject.Text.Trim();
            string messageText = tbMessage.Text;
            if (!Regex.IsMatch(to, @"^.+\@\w+\.\w+$") || subject.Equals(""))
            {
                MessageBox.Show("Некорректный адресс получателя\r\nили тема сообщения пуста!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MimeMessage message = new MimeMessage();
                message.From.Add(new MailboxAddress(from));

                //message.To.Add(new MailboxAddress();
            }
        }

        private void LnkAddAttachments_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dr = openFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string[] files = openFileDialog.SafeFileNames;
                if (files.Length > 0)
                {
                    _attachments = openFileDialog.FileNames;
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
