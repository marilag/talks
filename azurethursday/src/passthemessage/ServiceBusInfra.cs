using Azure.Messaging.ServiceBus;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;

namespace passthemessage
{
    public static class ServiceBusInfra
    {


        static string connectionString = "connectionstring here";
        static string queueName = "gossips";
        static ServiceBusSender sender;

       
        public async static void SendMessageFIFO(string sessionId, string message)
        {

            await using var client = new ServiceBusClient(connectionString);
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

            await using var client = new ServiceBusClient(connectionString);
            sender = client.CreateSender(queueName);



            var messageblocks = message.Split();
            var count = messageblocks.Length;


            try
            {

                for (int i = 0; i < count; i++)
                {
                    var sbmessage = new ServiceBusMessage(messageblocks[i])
                    {
                        SessionId = System.Guid.NewGuid().ToString()
                    };
                    await sender.SendMessageAsync(sbmessage);
                }

            }
            finally
            {

                await sender.DisposeAsync();

            }
        }

        public async static void SendMessageTransaction(string sessionId, string message)
        {

            await using var client = new ServiceBusClient(connectionString);
            sender = client.CreateSender(queueName);

            var messageblocks = message.Split();
            var count = messageblocks.Length;

            try
            {
                using (var ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    for (int i = 0; i < count; i++)
                    {
                       
                        var sbmessage = new ServiceBusMessage(messageblocks[i])
                        {
                            SessionId = sessionId
                        };
                        await sender.SendMessageAsync(sbmessage);

                    }
                    ts.Complete();
                }

            }            
            finally
            {

                await sender.DisposeAsync();

            }
        }

        public async static void SendMessageTopic(string sessionId, string message)
        {

            await using var client = new ServiceBusClient(connectionString);
            sender = client.CreateSender("juicygossips");

            var messageblocks = message.Split();
            var count = messageblocks.Length;

            try
            {
                using (var ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    for (int i = 0; i < count; i++)
                    {

                        var sbmessage = new ServiceBusMessage(messageblocks[i])
                        {
                            SessionId = sessionId
                        };
                        await sender.SendMessageAsync(sbmessage);

                    }
                    ts.Complete();
                }

            }
            finally
            {

                await sender.DisposeAsync();

            }
        }

 public async static void SendBatchMessageFIFO(string sessionId, string message)
        {

            await using var client = new ServiceBusClient(connectionString);
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


    }
}
