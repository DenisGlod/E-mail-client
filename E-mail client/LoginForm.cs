using MailKit.Net.Imap;
using MailKit.Security;
using System;
using System.Windows.Forms;

namespace E_mail_client
{
    public partial class LoginForm : Form
    {
        private const string EmailEmpty = "Email не может быть пустым!";
        private const string PasswordEmpty = "Пароль не может быть пустым!";
        private const string ErrorEmailOrPassword = "Неверный логин или пароль!";
        private const string SuccessConnect = "Авторизация успешна.";

        private const string GmailHost = "imap.gmail.com";
        private const string OutlookHost = "imap-mail.outlook.com";
        private const string YandexHost = "imap.yandex.ru";
        private const string MailRuHost = "imap.mail.ru";

        private const string SmtpGmailHost = "smtp.gmail.com";
        private const string SmtpOutlookHost = "smtp-mail.outlook.com";
        private const string SmtpYandexHost = "smtp.yandex.ru";
        private const string SmtpMailRuHost = "smtp.mail.ru";

        private const int PortImap = 993;
        private const int PortSmtp = 465;
        private const int PortSmtpOther = 587;

        private ClientProfile _clientProfile;

        public LoginForm()
        {
            InitializeComponent();
            comboBoxHost.SelectedIndex = 0;
            buttonLogin.Enabled = true;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            buttonLogin.Enabled = false;
            int indexHost = comboBoxHost.SelectedIndex;
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;
            if (string.IsNullOrEmpty(email))
            {
                Message(EmailEmpty, true);
            }
            else if (string.IsNullOrEmpty(password))
            {
                Message(PasswordEmpty, true);
            }
            else
            {
                switch (indexHost)
                {
                    case 0:
                        Conect(GmailHost, SmtpGmailHost, email, password, PortSmtp);
                        break;
                    case 1:
                        Conect(OutlookHost, SmtpOutlookHost, email, password, PortSmtpOther);
                        break;
                    case 2:
                        Conect(YandexHost, SmtpYandexHost, email, password, PortSmtp);
                        break;
                    case 3:
                        Conect(MailRuHost, SmtpMailRuHost, email, password, PortSmtp);
                        break;
                }
            }
        }
        private async void Conect(string host, string smtpHost, string email, string password, int smtpPort)
        {
            try
            {
                ImapClient imapClient = new ImapClient();
                await imapClient.ConnectAsync(host, PortImap, SecureSocketOptions.SslOnConnect);
                await imapClient.AuthenticateAsync(email, password);
                _clientProfile = new ClientProfile(imapClient, email, password, host, smtpHost, PortImap, smtpPort);
                Message(SuccessConnect, false);
            }
            catch (Exception e)
            {
                if (e is AuthenticationException || e is ImapProtocolException)
                {
                    Message(ErrorEmailOrPassword, true);
                }
                else
                {
                    Message(e.Message, true);
                }
            }
        }
        private void OpenFormEmailClient(object sender, EventArgs e)
        {
            timer.Enabled = false;
            new ClientForm(_clientProfile).Visible = true;
            Visible = false;
        }
        private void HideErrorMessage(object Sender, EventArgs e)
        {
            labelErrorMessage.Visible = false;
            timer.Enabled = false;
        }
        private void Message(string message, bool status)
        {
            if (status)
            {
                labelErrorMessage.Text = message;
                labelErrorMessage.BackColor = System.Drawing.Color.LightSalmon;
                labelErrorMessage.Visible = true;
                timer.Enabled = true;
            }
            else
            {
                labelErrorMessage.Text = message;
                labelErrorMessage.BackColor = System.Drawing.Color.LightGreen;
                labelErrorMessage.Visible = true;
                timer.Tick -= HideErrorMessage;
                timer.Tick += OpenFormEmailClient;
                timer.Interval = 1000;
                timer.Enabled = true;
                buttonLogin.Enabled = false;
                comboBoxHost.Enabled = false;
                textBoxEmail.Enabled = false;
                textBoxPassword.Enabled = false;
                checkBoxShowPassword.Enabled = false;
                pictureBox.Visible = true;
            }
        }
        private void CheckBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }
        private void Clear()
        {
            textBoxEmail.Clear();
            textBoxPassword.Clear();
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_clientProfile != null && _clientProfile.Client.IsConnected)
            {
                _clientProfile.Client.Disconnect(true);
            }
            Application.Exit();
        }
    }
}
