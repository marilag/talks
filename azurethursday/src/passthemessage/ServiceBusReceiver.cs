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
        [FunctionName("ServiceBusFifo")]
        public async Task Run([ServiceBusTrigger("gossips", Connection = "ServiceBusConnStr", IsSessionsEnabled = true)] Message message, MessageReceiver messageReceiver, ILogger log)
        {
            string messageBody = Encoding.UTF8.GetString(message.Body);
            await messageReceiver.CompleteAsync(message.SystemProperties.LockToken);
            Console.WriteLine($"{messageBody}");

        }

        [FunctionName("ServiceBusJuicyGossips1")]
        public  async Task ServiceBusJuicyGossips1([ServiceBusTrigger("juicygossips", "subscription1", Connection = "ServiceBusConnStr", IsSessionsEnabled = true)] Message message, MessageReceiver messageReceiver, ILogger log)
        {
            string messageBody = Encoding.UTF8.GetString(message.Body);

            await messageReceiver.CompleteAsync(message.SystemProperties.LockToken);

            Console.WriteLine($"ServiceBusJuicyGossips1 : {messageBody}");


        }

        [FunctionName("ServiceBusJuicyGossips2")]
        public  async Task ServiceBusJuicyGossips2([ServiceBusTrigger("juicygossips", "subscription2", Connection = "ServiceBusConnStr", IsSessionsEnabled = true)] Message message, MessageReceiver messageReceiver, ILogger log)
        {
            string messageBody = Encoding.UTF8.GetString(message.Body);

            await messageReceiver.CompleteAsync(message.SystemProperties.LockToken);

            Console.WriteLine($"ServiceBusJuicyGossips2 : {messageBody}");

        }
/* 
        [FunctionName("ServiceBusJuicyGossips3")]
        public async Task ServiceBusJuicyGossips3([ServiceBusTrigger("juicygossips", "subscription3", Connection = "ServiceBusConnStr", IsSessionsEnabled = true)] Message message, MessageReceiver messageReceiver, ILogger log)
        {
            string messageBody = Encoding.UTF8.GetString(message.Body);

            await messageReceiver.DeadLetterAsync(message.SystemProperties.LockToken);

            Console.WriteLine($"ServiceBusJuicyGossips3 : {messageBody}");

        }

        [FunctionName("ServiceBusJuicyGossipsDead")]
        public async Task ServiceBusJuicyDeadLetter([ServiceBusTrigger("juicygossips", "subscription3/$deadletterqueue", Connection = "ServiceBusConnStr")] Message message, MessageReceiver messageReceiver, ILogger log)
        {
            string messageBody = Encoding.UTF8.GetString(message.Body);
            

            await messageReceiver.CompleteAsync(message.SystemProperties.LockToken);

            Console.WriteLine($"DeadLetter Alert! : {messageBody}");

        } */

    }
}
