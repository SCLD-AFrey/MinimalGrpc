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

    /// <summary>Base class for server-side implementations of Orchestrator</summary>
    [grpc::BindServiceMethod(typeof(Orchestrator), "BindService")]
    public abstract partial class OrchestratorBase
    {
      public virtual global::System.Threading.Tasks.Task RegisterClient(global::OrchestratorService.G_RegisterClientRequest request, grpc::IServerStreamWriter<global::OrchestratorService.G_Response> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::OrchestratorService.G_Response> EnqueueRequest(global::OrchestratorService.G_OrchestrationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(OrchestratorBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_RegisterClient, serviceImpl.RegisterClient)
          .AddMethod(__Method_EnqueueRequest, serviceImpl.EnqueueRequest).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, OrchestratorBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_RegisterClient, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::OrchestratorService.G_RegisterClientRequest, global::OrchestratorService.G_Response>(serviceImpl.RegisterClient));
      serviceBinder.AddMethod(__Method_EnqueueRequest, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::OrchestratorService.G_OrchestrationRequest, global::OrchestratorService.G_Response>(serviceImpl.EnqueueRequest));
    }

  }
}
#endregion