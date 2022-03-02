﻿using Common;
using Confluent.Kafka;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProducerConsole
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var clientConfig = KafkaConfigFactory.GetConfluenceConfig();

            // Configure the client with credentials for connecting to Confluent.
            // Don't do this in production code. For more information, see 
            // https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets.

            await WikiProducer.Produce(KafkaConfig.Topic, clientConfig);

            Console.WriteLine("Exiting");
        }
    }
}