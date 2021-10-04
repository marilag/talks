using Azure.Storage.Queues;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace passthemessage
{
    public static class StorageQueueInfra
    {
        private const string QueueName = "gossips"; 
        

        public static void SendMessageToStorageQueue(string connStr, string message)
        {
            var messageblocks = message.Split();
            var count = messageblocks.Length;

            for (int i = 0; i < count; i++)
            {
                InsertMessage(connStr, messageblocks[i]);
            }
        }


        private static void InsertMessage(string connStr, string message)
        {

            // Instantiate a QueueClient which will be used to create and manipulate the queue
            QueueClient queueClient = new QueueClient(connStr, QueueName);

            // Create the queue if it doesn't already exist
            queueClient.CreateIfNotExists();

            if (queueClient.Exists())
            {
                // Send a message to the queue
                queueClient.SendMessage(Convert.ToBase64String(Encoding.UTF8.GetBytes(message)));
            }

        }
    }
}
