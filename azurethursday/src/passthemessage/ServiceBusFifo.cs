using System;
using System.Threading;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace passthemessage
{
    public static class ServiceBusFifo
    {
        [FunctionName("ServiceBusFifo")]
        public static void Run([ServiceBusTrigger("gossips", Connection = "ServiceBusConnStr")]string myQueueItem, ILogger log)
        {
            Console.WriteLine($"{myQueueItem}");
            Thread.Sleep(10000);


        }
    }
}
