using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;

namespace passthemessage
{
    public static class StorageQueueProducer
    {
        [FunctionName("gossip")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = null)] HttpRequest req,
            ExecutionContext context,
            ILogger log)
        {

            var config = new ConfigurationBuilder()
           .SetBasePath(context.FunctionAppDirectory)
           .AddJsonFile("local.settings.json", optional: true, reloadOnChange: true)
           .AddEnvironmentVariables()
           .Build();


            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            StorageQueueInfra.SendMessageToStorageQueue(config["StorageQueueConnectionString"], requestBody);
            return new OkResult();

        }
    }
}
