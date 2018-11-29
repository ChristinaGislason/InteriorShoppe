using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InteriorShoppe.Models
{
    public class EmailSender : IEmailSender
    {
        public IConfiguration Configuration { get; }

        public EmailSender(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SendGridClient(Configuration["SendGrid_Api_Key"]);

            var msg = new SendGridMessage();

            msg.SetFrom("admin@theWrightStuff.com");

            msg.AddTo(email);
            msg.SetSubject(subject);
            msg.AddContent(MimeType.Html, htmlMessage);

            var response = await client.SendEmailAsync(msg);
        }
    }
}
