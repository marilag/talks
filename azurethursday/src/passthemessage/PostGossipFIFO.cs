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
    public static class PostGossipFIFO
    {
        [FunctionName("gossipfifo")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ExecutionContext context,
            ILogger log)
        {
           
            var config = new ConfigurationBuilder()
           .SetBasePath(context.FunctionAppDirectory)
           .AddJsonFile("local.settings.json", optional: true, reloadOnChange: true)
           .AddEnvironmentVariables()
           .Build();


            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            ServiceBus.SendMessageFIFO(context.InvocationId.ToString(),requestBody);
            return new OkResult();
        }


        [FunctionName("gossiprandom")]
        public static async Task<IActionResult> gossiprandom(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ExecutionContext context,
            ILogger log)
        {

            var config = new ConfigurationBuilder()
           .SetBasePath(context.FunctionAppDirectory)
           .AddJsonFile("local.settings.json", optional: true, reloadOnChange: true)
           .AddEnvironmentVariables()
           .Build();


            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            ServiceBus.SendMessageRandom(requestBody);
            return new OkResult();
        }

         [FunctionName("gossipbatch")]
        public static async Task<IActionResult> gossipbatch(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ExecutionContext context,
            ILogger log)
        {

            var config = new ConfigurationBuilder()
           .SetBasePath(context.FunctionAppDirectory)
           .AddJsonFile("local.settings.json", optional: true, reloadOnChange: true)
           .AddEnvironmentVariables()
           .Build();


            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            ServiceBus.SendBatchMessageFIFO(context.InvocationId.ToString(),requestBody);
            return new OkResult();
        }
    }
}
