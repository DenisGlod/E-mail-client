using ImapX;
using System;
using System.Security.Authentication;
using System.Windows.Forms;

namespace E_mail_client
{
    public partial class StartForm : Form
    {
        private const string emailNullOrEmpty = "Email не может быть пустым!";
        private const string passwordNullOrEmpty = "Пароль не может быть пустым!";
        private const string errorEmailOrPassword = "Неверный логин или пароль!";
        private const string exceptionConnect = "Неудалось подключиться к серверу!";
        private const string success = "Авторизация успешна.";

        private const string gmailHost = "imap.gmail.com";
        private const string outlookHost = "imap-mail.outlook.com";
        private const string yandexHost = "imap.yandex.ru";
        private const int portImap = 993;
        private string email;
        private ImapClient client;
        public StartForm()
        {
            InitializeComponent();
            comboBoxHost.SelectedIndex = 0;
        }
        private void Login(object sender, EventArgs e)
        {
            int host = comboBoxHost.SelectedIndex;
            email = textBoxEmail.Text;
            string password = textBoxPassword.Text;
            if (string.IsNullOrEmpty(email))
            {
                Message(emailNullOrEmpty, true);
            }
            else if (string.IsNullOrEmpty(password))
            {
                Message(passwordNullOrEmpty, true);
            }
            else
            {
                switch (host)
                {
                    case 0:
                        Conect(gmailHost, email, password);
                        break;
                    case 1:
                        Conect(outlookHost, email, password);
                        break;
                    case 2:
                        Conect(yandexHost, email, password);
                        break;
                }
            }
        }
        private void Conect(string host, string email, string password)
        {
            client = new ImapClient(host, portImap, SslProtocols.Tls, true);
            if (client.Connect())
            {
                if (client.Login(email, password))
                {
                    Message(success, false);
                }
                else
                {
                    Message(errorEmailOrPassword, true);
                }
            }
            else
            {
                Message(exceptionConnect, true);
            }
        }
        private void OpenFormEmailClient(object sender, EventArgs e)
        {
            timer.Enabled = false;
            new EMailClient(client, email).Visible = true;
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

        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Disconnect();
        }
    }
}
