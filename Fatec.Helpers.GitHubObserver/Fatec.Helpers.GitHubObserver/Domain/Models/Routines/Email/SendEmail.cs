using Fatec.Helpers.GitHubObserver.Domain.Routines.Email;
using Fatec.Helpers.GitHubObserver.Domain.Routines.Email.Sender;
using FluentEmail.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fatec.Helpers.GitHubObserver.Domain.Models.Routines.Email
{
    class SendEmail : IRoutine
    {
        public void Execute(dynamic data)
        {
            IEmailSender emailSender = new EmailSenderImpl();

            emailSender.Send(new EmailBuilder(data).Build("diogojunqueirageraldo@gmail.com",
                                                           "Diogo Junqueira Geraldo"));
        }
    }
}
