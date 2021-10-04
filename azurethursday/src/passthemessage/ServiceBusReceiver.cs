using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;
using Azure.Messaging.ServiceBus;
using Microsoft.Azure.ServiceBus;
using Microsoft.Azure.ServiceBus.Core;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace passthemessage
{
    public  class ServiceBusReceive
         
    {
        //    [FunctionName("ServiceBusFifo")]
        //    public  async Task Run([ServiceBusTrigger("gossips", Connection = "ServiceBusConnStr", IsSessionsEnabled = true)] Message message, MessageReceiver messageReceiver, ILogger log)
        //    {
        //        string messageBody = Encoding.UTF8.GetString(message.Body);
        //        await messageReceiver.CompleteAsync(message.SystemProperties.LockToken);
        //        Console.WriteLine($"{messageBody}");


        //    }

        [FunctionName("ServiceBusReceiveTransaction")]
        public static async Task Run([ServiceBusTrigger("gossips", Connection = "ServiceBusConnStr", IsSessionsEnabled = true)] Message message, MessageReceiver messageReceiver, ILogger log)
        {
            log.LogInformation("Calling event");
            string connectionString = "Endpoint=sb://azurethursday2021p.servicebus.windows.net/;SharedAccessKeyName=app;SharedAccessKey=wfes74Xwh6MKP0sVs1jhPhppW1M5Op0KnJ5nqX4MClk=";
            string queueName = "cheesygossips";
            ServiceBusSender sender;

            string messageBody = Encoding.UTF8.GetString(message.Body);

            await using var client = new ServiceBusClient(connectionString);

            sender = client.CreateSender(queueName);

            try
            {
                using (var ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {

                    await messageReceiver.CompleteAsync(message.SystemProperties.LockToken);
                    //await sender.SendMessageAsync(new ServiceBusMessage($"cheesy {messageBody}")
                    //{
                    //    SessionId = System.Guid.NewGuid().ToString()
                    //});
                    ts.Complete();
                }
            }
            finally
            {

                await sender.DisposeAsync();

            }
            Console.WriteLine($"{messageBody}");

        }

        [FunctionName("ServiceBusJuicyGossips1")]
        public  async Task ServiceBusJuicyGossips1([ServiceBusTrigger("juicygossips", "subscription1", Connection = "ServiceBusConnStr", IsSessionsEnabled = true)] Message message, MessageReceiver messageReceiver, ILogger log)
        {
            string messageBody = Encoding.UTF8.GetString(message.Body);
            await messageReceiver.CompleteAsync(message.SystemProperties.LockToken);
            Console.WriteLine($"{messageBody}");


        }

        [FunctionName("ServiceBusJuicyGossips2")]
        public  async Task ServiceBusJuicyGossips2([ServiceBusTrigger("juicygossips", "subscription2", Connection = "ServiceBusConnStr", IsSessionsEnabled = true)] Message message, MessageReceiver messageReceiver, ILogger log)
        {
            string messageBody = Encoding.UTF8.GetString(message.Body);
            await messageReceiver.CompleteAsync(message.SystemProperties.LockToken);
            Console.WriteLine($"{messageBody}");


        }

    }
}
