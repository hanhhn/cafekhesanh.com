using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Coffee.Service
{
	public class EmailService : IEmailService
	{
		// Our private configuration variables
		private string host;
		private int port;
		private bool enableSSL;
		private string userName;
		private string password;
		private string mailFrom;

		// Get our parameterized configuration
		public EmailService(string host, int port, bool enableSSL, string userName, string password, string mailFrom)
		{
			this.host = host;
			this.port = port;
			this.enableSSL = enableSSL;
			this.userName = userName;
			this.mailFrom = mailFrom;
			this.password = password;
		}

		// Use our configuration to send the email by using SmtpClient
		public Task SendEmailAsync(string email, string subject, string htmlMessage)
		{
			var client = new SmtpClient(host, port)
			{
				Credentials = new NetworkCredential(userName, password),
				EnableSsl = enableSSL,
			};

			return client.SendMailAsync(new MailMessage(mailFrom, email, subject, htmlMessage)
			{
				IsBodyHtml = true
			});
		}
	}
}