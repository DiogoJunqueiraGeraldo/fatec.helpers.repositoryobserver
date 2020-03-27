using Fatec.Helpers.GitHubObserver.Domain.Models;
using Fatec.Helpers.GitHubObserver.Domain.Models.Factories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Fatec.Helpers.GitHubObserver.Application.Controllers
{
    class GitHubController
    {
        public async Task<IActionResult> HandleWebHookAsync(HttpRequest req)
        {
            try
            {
                Observer observer = ObserverFactory.CreateObserver();

                string requestBody = await new StreamReader(req.Body).ReadToEndAsync();

                dynamic data = JsonConvert.DeserializeObject(requestBody);

                observer.NotifyAll(data);

                return new OkObjectResult("Rotinas executadas!");

            } catch (Exception) { 
                return new BadRequestObjectResult("Erro ao executar as rotinas!");
            }
        }
    }
}
