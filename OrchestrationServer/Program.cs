using System;
using Grpc.Core;
using OrchestratorService;
using Common;

namespace OrchestrationServer
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Starting authentication server...");

            var AuthenticationServer = new Server()
            {
                Services = { AuthenticationServiceProto.AuthenticatorServiceRpc.BindService(new Services.AuthenticatorService()) },
                Ports = { new ServerPort("localhost", Constants.Ports.Authentication, ServerCredentials.Insecure) }
            };

            AuthenticationServer.Start();

            Console.WriteLine("Authentication Server Listening...");
            Console.WriteLine("Starting orchestration server...");

            var OrchestrationServer = new Server()
            {
                Services = { Orchestrator.BindService(new Services.OrchestratorService()) },
                Ports = { new ServerPort("localhost", Constants.Ports.Orchestrator, ServerCredentials.Insecure) }
            };

            OrchestrationServer.Start();

            Console.WriteLine("Orchestrator Listening...");
            Console.WriteLine("Press any key to stop server...");
            Console.ReadKey(true);

            OrchestrationServer.ShutdownAsync().Wait();
        }
    }
}