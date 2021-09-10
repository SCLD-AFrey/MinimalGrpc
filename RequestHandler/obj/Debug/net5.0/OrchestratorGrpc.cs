// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: orchestrator.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace OrchestratorService {
  public static partial class Orchestrator
  {
    static readonly string __ServiceName = "test.Orchestrator";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::OrchestratorService.G_RegisterClientRequest> __Marshaller_test_G_RegisterClientRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::OrchestratorService.G_RegisterClientRequest.Parser));
    static readonly grpc::Marshaller<global::OrchestratorService.G_Response> __Marshaller_test_G_Response = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::OrchestratorService.G_Response.Parser));
    static readonly grpc::Marshaller<global::OrchestratorService.G_OrchestrationRequest> __Marshaller_test_G_OrchestrationRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::OrchestratorService.G_OrchestrationRequest.Parser));

    static readonly grpc::Method<global::OrchestratorService.G_RegisterClientRequest, global::OrchestratorService.G_Response> __Method_RegisterClient = new grpc::Method<global::OrchestratorService.G_RegisterClientRequest, global::OrchestratorService.G_Response>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "RegisterClient",
        __Marshaller_test_G_RegisterClientRequest,
        __Marshaller_test_G_Response);

    static readonly grpc::Method<global::OrchestratorService.G_OrchestrationRequest, global::OrchestratorService.G_Response> __Method_EnqueueRequest = new grpc::Method<global::OrchestratorService.G_OrchestrationRequest, global::OrchestratorService.G_Response>(
        grpc::MethodType.Unary,
        __ServiceName,
        "EnqueueRequest",
        __Marshaller_test_G_OrchestrationRequest,
        __Marshaller_test_G_Response);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::OrchestratorService.OrchestratorReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for Orchestrator</summary>
    public partial class OrchestratorClient : grpc::ClientBase<OrchestratorClient>
    {
      /// <summary>Creates a new client for Orchestrator</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public OrchestratorClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Orchestrator that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public OrchestratorClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected OrchestratorClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected OrchestratorClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncServerStreamingCall<global::OrchestratorService.G_Response> RegisterClient(global::OrchestratorService.G_RegisterClientRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RegisterClient(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::OrchestratorService.G_Response> RegisterClient(global::OrchestratorService.G_RegisterClientRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_RegisterClient, null, options, request);
      }
      public virtual global::OrchestratorService.G_Response EnqueueRequest(global::OrchestratorService.G_OrchestrationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return EnqueueRequest(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::OrchestratorService.G_Response EnqueueRequest(global::OrchestratorService.G_OrchestrationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_EnqueueRequest, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::OrchestratorService.G_Response> EnqueueRequestAsync(global::OrchestratorService.G_OrchestrationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return EnqueueRequestAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::OrchestratorService.G_Response> EnqueueRequestAsync(global::OrchestratorService.G_OrchestrationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_EnqueueRequest, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override OrchestratorClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new OrchestratorClient(configuration);
      }
    }

  }
}
#endregion