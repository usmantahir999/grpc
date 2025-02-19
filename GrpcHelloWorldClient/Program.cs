using Grpc.Net.Client;
using GrpcHelloWorldClient.Protos;
using System;
using System.Threading.Tasks;

namespace GrpcHelloWorldClient
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new HelloService.HelloServiceClient(channel);
            var reply = await client.SayHelloAsync(new HelloRequest { Name = "Hello Usman Client" });
            Console.WriteLine($"Greeting: {reply.Message}");
            Console.ReadKey();
        }
    }
}
