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
    public static class SerivceBusProducer
    {
        [FunctionName("gossipfifo")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ExecutionContext context,
            ILogger log)
        {

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            ServiceBusInfra.SendMessageFIFO(context.InvocationId.ToString(),requestBody);
            return new OkResult();
        }


        [FunctionName("gossiprandom")]
        public static async Task<IActionResult> gossiprandom(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ExecutionContext context,
            ILogger log)
        {

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            ServiceBusInfra.SendMessageRandom(requestBody);
            return new OkResult();
        }

        [FunctionName("gossipbatch")]
        public static async Task<IActionResult> gossipbatch(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ExecutionContext context,
            ILogger log)
        {

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            ServiceBusInfra.SendBatchMessageFIFO(context.InvocationId.ToString(),requestBody);
            return new OkResult();
        }

        [FunctionName("gossiptransaction")]
        public static async Task<IActionResult> gossiptransaction(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ExecutionContext context,
            ILogger log)
        {

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            ServiceBusInfra.SendMessageTransaction(context.InvocationId.ToString(),requestBody);
            return new OkResult();
        }

        [FunctionName("juicygossip")]
        public static async Task<IActionResult> juicygossip(
           [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
           ExecutionContext context,
           ILogger log)
        {


            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            ServiceBusInfra.SendMessageTopic(context.InvocationId.ToString(), requestBody);
            return new OkResult();
        }
    }
}
