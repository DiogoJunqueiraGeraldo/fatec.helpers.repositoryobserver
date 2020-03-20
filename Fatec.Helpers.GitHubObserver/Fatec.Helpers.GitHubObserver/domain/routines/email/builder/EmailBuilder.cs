using FluentEmail.Core;
using FluentEmail.Mailgun;
using FluentEmail.Razor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fatec.Helpers.GitHubObserver.domain.routines.email
{
    class EmailBuilder
    {
        public string Template { get; private set; }
        public dynamic Data { get; private set; }

        public EmailBuilder(dynamic data)
        {
            Email.DefaultRenderer = new RazorRenderer();
            Email.DefaultSender = new MailgunSender(
                "domain",
                "apikey"
            );

            this.Template = "Um novo commit no repositorio @Model.RepositoryName foi realizado \n Mudanças: @Model.Changes";

            this.SetClearData(data);
        }
        public Email Build()
        {
            return (Email) Email
                            .From("fatec.helpers@gmail.com")
                            .To("diogojunqueirageraldo@gmail.com")
                            .Subject("[Fatec.Helpers] Commit Realizado na Branch Master")
                            .UsingTemplate(this.Template, new { 
                                RepositoryName = this.Data["RepositoryName"], 
                                Changes = this.Data["Changes"]
                            });
        }

        private void SetClearData(dynamic data)
        {
            this.Data = data;
        }
    }
}
