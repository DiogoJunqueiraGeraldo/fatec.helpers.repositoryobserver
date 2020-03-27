using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Fatec.Helpers.GitHubObserver.Domain.Models;
using Fatec.Helpers.GitHubObserver.Domain.Models.Factories;

namespace Fatec.Helpers.GitHubObserver
{
    public static class NotifyAllFunction
    {
        [FunctionName("NotifyAllFunction")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            Observer observer = ObserverFactory.CreateObserver();

            log.LogInformation("C# HTTP trigger function processed a request.");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();

            dynamic data = JsonConvert.DeserializeObject(requestBody);

            observer.NotifyAll(data);

            return new OkObjectResult("Rotinas executadas!");
        }
    }
}
