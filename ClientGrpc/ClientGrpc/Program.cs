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
            //var reply = await client.SayHelloAsync(new HelloRequest { Name = "Daniel Haag" });

            //Console.WriteLine("Saudação: " + reply.Message);
            //Console.WriteLine("Pressione qualquer tecla para sair...");
            //Console.ReadKey();

            var reply = await client.TestingMethodAsync(new TestingMethodRequest { TestName = "Teste envio" });
            Console.WriteLine("Saudação: " + reply.TesteMessage);
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
