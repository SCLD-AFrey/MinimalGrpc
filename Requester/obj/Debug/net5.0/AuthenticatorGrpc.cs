// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: authenticator.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace AuthenticationServiceProto {
  public static partial class AuthenticatorServiceRpc
  {
    static readonly string __ServiceName = "test.AuthenticatorServiceRpc";

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

    static readonly grpc::Marshaller<global::AuthenticationServiceProto.AuthRequest> __Marshaller_test_AuthRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::AuthenticationServiceProto.AuthRequest.Parser));
    static readonly grpc::Marshaller<global::AuthenticationServiceProto.AuthReply> __Marshaller_test_AuthReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::AuthenticationServiceProto.AuthReply.Parser));

    static readonly grpc::Method<global::AuthenticationServiceProto.AuthRequest, global::AuthenticationServiceProto.AuthReply> __Method_ReturnToken = new grpc::Method<global::AuthenticationServiceProto.AuthRequest, global::AuthenticationServiceProto.AuthReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ReturnToken",
        __Marshaller_test_AuthRequest,
        __Marshaller_test_AuthReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::AuthenticationServiceProto.AuthenticatorReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for AuthenticatorServiceRpc</summary>
    public partial class AuthenticatorServiceRpcClient : grpc::ClientBase<AuthenticatorServiceRpcClient>
    {
      /// <summary>Creates a new client for AuthenticatorServiceRpc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public AuthenticatorServiceRpcClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for AuthenticatorServiceRpc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public AuthenticatorServiceRpcClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected AuthenticatorServiceRpcClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected AuthenticatorServiceRpcClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::AuthenticationServiceProto.AuthReply ReturnToken(global::AuthenticationServiceProto.AuthRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ReturnToken(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::AuthenticationServiceProto.AuthReply ReturnToken(global::AuthenticationServiceProto.AuthRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ReturnToken, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::AuthenticationServiceProto.AuthReply> ReturnTokenAsync(global::AuthenticationServiceProto.AuthRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ReturnTokenAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::AuthenticationServiceProto.AuthReply> ReturnTokenAsync(global::AuthenticationServiceProto.AuthRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ReturnToken, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override AuthenticatorServiceRpcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AuthenticatorServiceRpcClient(configuration);
      }
    }

  }
}
#endregion