using FluentEmail.Core;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Fatec.Helpers.GitHubObserver.Domain.Routines.Email.Sender
{
    interface IEmailSender
    {
        void Send(MailMessage email);
    }
}
