using FluentEmail.Core;
using FluentEmail.Mailgun;
using FluentEmail.Razor;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Fatec.Helpers.GitHubObserver.Domain.Routines.Email
{
    class EmailBuilder
    {
        private dynamic Data { get; set; }
        private MailMessage Message { get; set; }

        public EmailBuilder(dynamic data)
        {
            this.Data = data;
            this.Message = new MailMessage();
        }
        public MailMessage Build(string to, string name)
        {
            this.Message.To.Add(new MailAddress(to, name));
            this.Message.From = new MailAddress("fatec.helpers@gmail.com", "Fatec.Helpers GitHub");
            this.Message.Subject = "[Fatec Helpers]";
            this.Message.Body = this.GetClearData();
            this.Message.IsBodyHtml = false;

            return this.Message;
        }

        private string GetClearData()
        {
            return Convert.ToString(this.Data);
        }
    }
}
