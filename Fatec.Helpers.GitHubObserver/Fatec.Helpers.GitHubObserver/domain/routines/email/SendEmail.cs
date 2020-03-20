using Fatec.Helpers.GitHubObserver.domain.routines.email;
using Fatec.Helpers.GitHubObserver.models;
using FluentEmail.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fatec.Helpers.GitHubObserver.domain.routines
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
