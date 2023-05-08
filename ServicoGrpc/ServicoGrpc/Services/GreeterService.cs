using Grpc.Core;
using Microsoft.AspNetCore.Server.IIS.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicoGrpc
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = "Olá " + request.Name
            });
        }

        public override Task<TestingMethodReply> TestingMethod(TestingMethodRequest request, ServerCallContext context)
        {
            if (request.TestName == "Teste envio")
            {
                return Task.FromResult(new TestingMethodReply
                {
                    TesteMessage = "Teste retorno"
                });
            }
            else
            {
                return null;
            }
        }
    }
}
