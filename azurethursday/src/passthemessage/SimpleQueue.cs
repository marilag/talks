using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace passthemessage
{
    public static class SimpleQueue
    {
        [FunctionName("SimpleQueue")]
        public static void Run([QueueTrigger("gossips", Connection = "StorageQueueConnectionString")]string myQueueItem, ILogger log)
        {
            Console.WriteLine($"{myQueueItem}");
        }
    }
}
