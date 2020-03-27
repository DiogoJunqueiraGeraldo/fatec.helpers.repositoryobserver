using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Fatec.Helpers.GitHubObserver.Application.Controllers;

namespace Fatec.Helpers.GitHubObserver
{
    public static class NotifyAllFunction
    {
        [FunctionName("NotifyAllFunction")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            GitHubController controller = new GitHubController();

            IActionResult result = await controller.HandleWebHookAsync(req);

            return result;
        }
    }
}
