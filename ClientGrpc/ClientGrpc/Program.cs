using Grpc.Net.Client;
using ServicoGrpc;
using System;
using System.Threading.Tasks;

namespace ClientGrpc
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);
            var reply = await client.SayHelloAsync(new HelloRequest { Name = "Daniel Haag" });
            Console.WriteLine("Saudação: " + reply.Message);
            Console.WriteLine("Pressione qualquer coisa para sair...");
            Console.ReadKey();
        }
    }
}
