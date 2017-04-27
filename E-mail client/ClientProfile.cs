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

        public ClientProfile(ImapClient client, string email, string password, string host, int port)
        {
            Client = client;
            Email = email;
            Password = password;
            Host = host;
            Port = port;
        }
        public ClientProfile(string email, string password, string host, int port)
        {
            Email = email;
            Password = password;
            Host = host;
            Port = port;
        }
        public ClientProfile()
        {

        }
        public bool Reconnect()
        {
            Client.Connect(Host, Port, SecureSocketOptions.SslOnConnect);
            Client.Authenticate(Email, Password);
            if(Client.IsConnected && Client.IsAuthenticated)
            {
                return true;
            }
            return false;
        }
    }
}
