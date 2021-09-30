using Azure.Messaging.ServiceBus;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace passthemessage
{
    public static class ServiceBus
    {


        static string connectionString = "Endpoint=sb://azurethursday102021.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=H3MJo46ypNuN6VHdiJQ3PSxIVLfws4UBxBNOXEgM8ro=";

        static string queueName = "gossips";

        static ServiceBusClient client;

        static ServiceBusSender sender;

        public async static void SendBatchMessageFIFO(string sessionId, string message)
        {

            client = new ServiceBusClient(connectionString);
            sender = client.CreateSender(queueName);

            // create a batch 
            using ServiceBusMessageBatch messageBatch = await sender.CreateMessageBatchAsync();

            var messageblocks = message.Split();
            var count = messageblocks.Length;

            for (int i = 0; i < count; i++)
            {
                var sbmessage = new ServiceBusMessage(messageblocks[i])
                {
                    SessionId = sessionId
                };

                if (!messageBatch.TryAddMessage(sbmessage))
                {
                    // if it is too large for the batch
                    throw new Exception($"The message {i} is too large to fit in the batch.");
                }
            }

            try
            {

                await sender.SendMessagesAsync(messageBatch);

            }
            finally
            {

                await sender.DisposeAsync();

            }
        }
        public async static void SendMessageFIFO(string sessionId, string message)
        {

            client = new ServiceBusClient(connectionString);
            sender = client.CreateSender(queueName);



            var messageblocks = message.Split();
            var count = messageblocks.Length;



            try
            {

                for (int i = 0; i < count; i++)
                {
                    var sbmessage = new ServiceBusMessage(messageblocks[i])
                    {
                        SessionId = sessionId
                    };

                    await sender.SendMessageAsync(sbmessage);

                }

            }
            finally
            {

                await sender.DisposeAsync();

            }
        }
        public async static void SendMessageRandom(string message)
        {

            client = new ServiceBusClient(connectionString);
            sender = client.CreateSender(queueName);



            var messageblocks = message.Split();
            var count = messageblocks.Length;


            try
            {

                for (int i = 0; i < count; i++)
                {
                    var sbmessage = new ServiceBusMessage(messageblocks[i]);
                    await sender.SendMessageAsync(sbmessage);

                }

            }
            finally
            {

                await sender.DisposeAsync();

            }
        }
    }
}
