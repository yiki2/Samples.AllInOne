﻿using System;
using Grpc.Core;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Grpc.Net.Client;
using Grpc.Demo.Server;

namespace Grpc.Demo.Client
{
    class Program
    {
        async static Task Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);
            var reply = await client.SayHelloAsync(
                new HelloRequest { Name = "Grpc!" });
            Console.WriteLine("Greeter Return: " + reply.Message);
            Console.ReadKey();
        }
    }
}