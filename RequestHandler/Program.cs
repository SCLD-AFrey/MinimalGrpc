using System;
using Grpc.Core;
using Common;
using RequestHandlerService;

namespace RequestHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting request handler server...");

            var server = new Server()
            {
                Services = { Handler.BindService(new Services.HandlerService()) },
                Ports = { new ServerPort("localhost", Constants.Ports.RequestHandler, ServerCredentials.Insecure) }
            };

            server.Start();

            Console.WriteLine("Listening...");
            Console.WriteLine("Press any key to stop server...");
            Console.ReadKey(true);

            server.ShutdownAsync().Wait();
        }
    }
}