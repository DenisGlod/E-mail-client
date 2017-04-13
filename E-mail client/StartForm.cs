using ImapX;
using System;
using System.Security.Authentication;
using System.Windows.Forms;

namespace E_mail_client
{
    public partial class StartForm : Form
    {
        private const string gmailHost = "imap.gmail.com";
        private const string mailHost = "imap.mail.ru";
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
            switch (host)
            {
                case 0:
                    Conect(gmailHost, email, password);
                    break;
                case 1:
                    Conect(mailHost, email, password);
                    break;
                case 2:
                    Conect(yandexHost, email, password);
                    break;
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
        private void Conect(string host, string email, string password)
        {
            client = new ImapClient(host, portImap, SslProtocols.Tls, true);
            if (client.Connect())
            {
                if (email.Length > 0 && password.Length > 0 && client.Login(email, password))
                {
                    labelErrorMessage.Text = "Авторизация успешна.";
                    labelErrorMessage.BackColor = System.Drawing.Color.LightGreen;
                    labelErrorMessage.Visible = true;
                    timer.Tick -= HideErrorMessage;
                    timer.Tick += OpenFormEmailClient;
                    timer.Enabled = true;
                }
                else
                {
                    labelErrorMessage.Text = "Ошибка! Неверный логин или пароль";
                    labelErrorMessage.BackColor = System.Drawing.Color.LightSalmon;
                    labelErrorMessage.Visible = true;
                    timer.Enabled = true;
                }
            }
            else
            {
                labelErrorMessage.Text = "Ошибка! Не удалось подключиться к серверу.";
                labelErrorMessage.BackColor = System.Drawing.Color.LightSalmon;
                labelErrorMessage.Visible = true;
                timer.Enabled = true;
            }
        }

        private void OpenFormEmailClient(object sender, EventArgs e)
        {
            timer.Enabled = false;
            new EMailClient(client, email).Visible = true;
            Visible = false;
            Clear();

        }

        private void HideErrorMessage(object Sender, EventArgs e)
        {
            labelErrorMessage.Visible = false;
            timer.Enabled = false;
        }
        private void Clear()
        {
            textBoxEmail.Clear();
            textBoxPassword.Clear();
            textBoxPassword.UseSystemPasswordChar = true;
        }
    }
}
