using FluentEmail.Core;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Fatec.Helpers.GitHubObserver.domain.routines.email
{
    class EmailSenderImpl : IEmailSender
    {
        public void Send(MailMessage email)
        {
            using (var client = new SmtpClient("smtp.gmail.com"))
            {
                client.Port = 587;
                client.Credentials = new NetworkCredential("fatec.helpers@gmail.com", "");
                client.EnableSsl = true;
                client.Send(email);
            }
        }
    }
}
