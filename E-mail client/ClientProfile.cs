using MailKit.Net.Imap;
using MailKit.Security;

namespace E_mail_client
{
    public class ClientProfile
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public ImapClient Client { get; set; }
        public string SmtpHost { get; set; }
        public int SmtpPort { get; set; }

        public ClientProfile(ImapClient client, string email, string password, string host, string smtpHost, int port, int smtpPort)
        {
            Client = client;
            Email = email;
            Password = password;
            Host = host;
            SmtpHost = smtpHost;
            Port = port;
            SmtpPort = smtpPort;
        }

        public bool Reconnect()
        {
            Client.Connect(Host, Port, SecureSocketOptions.SslOnConnect);
            Client.Authenticate(Email, Password);
            if (Client.IsConnected && Client.IsAuthenticated)
            {
                return true;
            }
            return false;
        }
    }
}
