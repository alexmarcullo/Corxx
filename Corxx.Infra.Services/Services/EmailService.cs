using Corxx.Domain.Services;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Corxx.Infra.Services.Services
{
    public class EmailService : IEmailService
    {
        public EmailService(string hostName, int port, string credentialsUserName, string credentialsPassword, bool ensableSsl = false)
        {
            _hostName = hostName;
            _port = port;
            _ensableSsl = ensableSsl;
            _credentialsUserName = credentialsUserName;
            _credentialsPassword = credentialsPassword;
        }

        public string _hostName { get; private set; }
        public int _port { get; private set; }
        public bool _ensableSsl { get; private set; }
        public string _credentialsUserName { get; private set; }
        public string _credentialsPassword { get; private set; }


        public async Task SendAsync(string from, string displayName, string to, string subject, string body)
        {
            using (SmtpClient client = new SmtpClient(_hostName, _port)
            {
                Host = _hostName,
                EnableSsl = _ensableSsl,
                Credentials = new NetworkCredential(_credentialsUserName, _credentialsPassword)
            })
            {
                // Montando Mensagem para enviar
                MailMessage message = new MailMessage
                {
                    Sender = new MailAddress(from)
                };
                message.To.Add(new MailAddress(to));
                message.From = new MailAddress(from, displayName);
                message.Subject = subject;
                message.Priority = MailPriority.High;
                message.IsBodyHtml = true;

                message.Body = body;
                await Task.Run(() => client.Send(message));
            }
        }
    }
}
