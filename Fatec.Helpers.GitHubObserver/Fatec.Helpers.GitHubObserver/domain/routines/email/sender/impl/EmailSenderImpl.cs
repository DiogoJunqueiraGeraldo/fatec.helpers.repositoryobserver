using FluentEmail.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fatec.Helpers.GitHubObserver.domain.routines.email
{
    class EmailSenderImpl : IEmailSender
    {
        public void Send(Email email)
        {
            email.SendAsync();
        }
    }
}
