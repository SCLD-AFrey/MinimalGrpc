using System;
using System.Threading.Tasks;
using Grpc.Core;
using OrchestratorService;
using RequestHandlerService;
using AuthenticationServiceProto;
using Common;

namespace Requester
{
    class Program
    {
        private static string _token;
        static async Task Main()
        {

            if (_token == null)
            {
                Console.WriteLine("Starting Authentication Server...");
                var authchannel = new Channel($"localhost:{Constants.Ports.Authentication}", ChannelCredentials.Insecure);
                var authclient = new AuthenticatorServiceRpc.AuthenticatorServiceRpcClient(authchannel);

                var reply = await authclient.ReturnTokenAsync(new AuthRequest()
                {
                    Username = "afrey"
                });
                

            }



            Console.WriteLine("Starting Orchestration Server...");
            var channel = new Channel($"localhost:{Constants.Ports.Orchestrator}", ChannelCredentials.Insecure);
            var client = new Orchestrator.OrchestratorClient(channel);

            var clientId = Guid.NewGuid().ToString();
            
            Console.WriteLine("Attempting to register client with server...");

            var responseStream = client.RegisterClient(new G_RegisterClientRequest()
            {
                ClientId = clientId
            });

            Task.Run(async () => MonitorMessages(responseStream));

            ConsoleKey key;

            Console.WriteLine("Press a key to send a server request. Press 'Q' to quit...");
            
            do
            {
                key = Console.ReadKey(true).Key;
                var endpointRequest = new G_OrchestrationRequest()
                {
                    OriginId = clientId,
                    RequestType1 = new G_RequestType1
                    {
                        OriginId = clientId
                    }
                };
                
                Console.WriteLine("Sending client request to server...");

                try
                {
                    var reply = client.EnqueueRequest(endpointRequest);
                    
                    Console.WriteLine(reply.Response);
                }
                catch (RpcException exception)
                {
                    Console.WriteLine($"The server could not be reached - Status Code: {exception.StatusCode}");
                }
                
            } while (key != ConsoleKey.Q);
        }
        
        private static async void MonitorMessages(AsyncServerStreamingCall<G_Response> p_responseStream)
        {
            while (true)
            {
                while (await p_responseStream.ResponseStream.MoveNext())
                {
                    var response = p_responseStream.ResponseStream.Current;
                    Console.WriteLine(response.Response);
                }

                await Task.Delay(100);
            }
        }
    }
}