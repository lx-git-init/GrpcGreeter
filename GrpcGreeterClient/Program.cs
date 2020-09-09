using Grpc.Net.Client;
using GrpcGreeter;
using System;

namespace GrpcGreeterClient
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);
            var reply = client.SayHello(new HelloRequest { Name = "kuxue" });
            Console.WriteLine(reply.Message);
            Console.ReadKey();
        }
    }
}