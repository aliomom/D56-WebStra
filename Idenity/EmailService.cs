﻿using Microsoft.AspNet.Identity;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Identity
{
    public class EmailService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            // Create the mail message
            var mailMessage = new MailMessage(
                "myapp@myapp.com",
                message.Destination,
                message.Subject,
                message.Body
                );

            // Send the message
            SmtpClient client = new SmtpClient();
            client.SendAsync(mailMessage, null);

            return Task.FromResult(true);
        }
    }
}