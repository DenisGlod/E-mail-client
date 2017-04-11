using System;
using System.Windows.Forms;
using ImapX;
using System.Security.Authentication;
using ImapX.Authentication;

namespace E_mail_client
{
    public partial class FormLogin : Form
    {
        private const string gmailHost = "imap.gmail.com";
        private const string mailHost = "imap.mail.ru";
        private const string yandexHost = "imap.yandex.ru";
        private const int portImap = 993;

        public FormLogin()
        {
            InitializeComponent();
            comboBoxHost.SelectedIndex = 0;
        }

        private void Login(object sender, EventArgs e)
        {
            int host = comboBoxHost.SelectedIndex;
            string email = textBoxEmail.Text;
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
            ImapClient client = new ImapClient(host, portImap, SslProtocols.Ssl3, false);

            if (client.Connect())
            {
                var credentials = new OAuth2Credentials("login", "token");
                if (email.Length > 0 && password.Length > 0 && client.Login(email, password))
                {
                    MessageBox.Show("Авторизация успешна.", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ошибка! Неверный логин или пароль", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ошибка! Не удалось подключиться к серверу.", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
