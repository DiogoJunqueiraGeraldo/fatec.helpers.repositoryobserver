using FluentEmail.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fatec.Helpers.GitHubObserver.domain.routines.email
{
    interface IEmailSender
    {
        void Send(Email email);
    }
}
