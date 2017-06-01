using MailKit.Net.Smtp;
using MailKit.Security;
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
            MimeMessage message = new MimeMessage();
            if (!Regex.IsMatch(to, @"^.+\@\w+\.\w+$") || subject.Equals(""))
            {
                MessageBox.Show("Некорректный адресс получателя\r\nили тема сообщения пуста!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                message.From.Add(new MailboxAddress(from));
                message.To.Add(new MailboxAddress(to));
                message.Subject = subject;

                var builder = new BodyBuilder();

                if (rbText.Checked)
                {
                    builder.TextBody = messageText;
                }
                else if (rbHtml.Checked)
                {
                    builder.HtmlBody = messageText;
                }
                if (_attachments != null)
                {
                    foreach (string str in _attachments)
                    {
                        builder.Attachments.Add(str);
                    }
                }
                message.Body = builder.ToMessageBody();
                using (var client = new SmtpClient())
                {
                    client.Connect(_clientProfile.SmtpHost, _clientProfile.SmtpPort, SecureSocketOptions.SslOnConnect);
                    client.Authenticate(_clientProfile.Email, _clientProfile.Password);
                    client.Send(message);
                    client.Disconnect(true);
                }
                AllClear();
                MessageBox.Show("Сообщение успешно отправлено!", "Отправка сообщения", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void DeleteAttachments_Click(object sender, EventArgs e)
        {
            lnkAddAttachments.Text = "Добавить вложения";
            _attachments = null;
        }

        private void AllClear()
        {
            tbSubject.Clear();
            tbTo.Clear();
            tbMessage.Clear();
            _attachments = null;
            lnkAddAttachments.Text = "Добавить вложения";
        }
    }
}
