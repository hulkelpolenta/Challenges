// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/auctionserv.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace AuctionGrpcService {
  public static partial class AuctionServ
  {
    static readonly string __ServiceName = "auctionserv.AuctionServ";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
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

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
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

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::AuctionGrpcService.AuctionNewRequest> __Marshaller_auctionserv_AuctionNewRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::AuctionGrpcService.AuctionNewRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::AuctionGrpcService.AuctionBasicReply> __Marshaller_auctionserv_AuctionBasicReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::AuctionGrpcService.AuctionBasicReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::AuctionGrpcService.AuctionAddRequest> __Marshaller_auctionserv_AuctionAddRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::AuctionGrpcService.AuctionAddRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::AuctionGrpcService.AuctionRequest> __Marshaller_auctionserv_AuctionRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::AuctionGrpcService.AuctionRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::AuctionGrpcService.AuctionGetReply> __Marshaller_auctionserv_AuctionGetReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::AuctionGrpcService.AuctionGetReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::AuctionGrpcService.AuctionBidRequest> __Marshaller_auctionserv_AuctionBidRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::AuctionGrpcService.AuctionBidRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::AuctionGrpcService.AuctionBidUsersRequest> __Marshaller_auctionserv_AuctionBidUsersRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::AuctionGrpcService.AuctionBidUsersRequest.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::AuctionGrpcService.AuctionNewRequest, global::AuctionGrpcService.AuctionBasicReply> __Method_AuctionNew = new grpc::Method<global::AuctionGrpcService.AuctionNewRequest, global::AuctionGrpcService.AuctionBasicReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AuctionNew",
        __Marshaller_auctionserv_AuctionNewRequest,
        __Marshaller_auctionserv_AuctionBasicReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::AuctionGrpcService.AuctionAddRequest, global::AuctionGrpcService.AuctionBasicReply> __Method_AuctionAdd = new grpc::Method<global::AuctionGrpcService.AuctionAddRequest, global::AuctionGrpcService.AuctionBasicReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AuctionAdd",
        __Marshaller_auctionserv_AuctionAddRequest,
        __Marshaller_auctionserv_AuctionBasicReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::AuctionGrpcService.AuctionRequest, global::AuctionGrpcService.AuctionGetReply> __Method_AuctionGet = new grpc::Method<global::AuctionGrpcService.AuctionRequest, global::AuctionGrpcService.AuctionGetReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AuctionGet",
        __Marshaller_auctionserv_AuctionRequest,
        __Marshaller_auctionserv_AuctionGetReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::AuctionGrpcService.AuctionBidRequest, global::AuctionGrpcService.AuctionBasicReply> __Method_AuctionBidNew = new grpc::Method<global::AuctionGrpcService.AuctionBidRequest, global::AuctionGrpcService.AuctionBasicReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AuctionBidNew",
        __Marshaller_auctionserv_AuctionBidRequest,
        __Marshaller_auctionserv_AuctionBasicReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::AuctionGrpcService.AuctionBidUsersRequest, global::AuctionGrpcService.AuctionBasicReply> __Method_AuctionBidAdd = new grpc::Method<global::AuctionGrpcService.AuctionBidUsersRequest, global::AuctionGrpcService.AuctionBasicReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AuctionBidAdd",
        __Marshaller_auctionserv_AuctionBidUsersRequest,
        __Marshaller_auctionserv_AuctionBasicReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::AuctionGrpcService.AuctionservReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of AuctionServ</summary>
    [grpc::BindServiceMethod(typeof(AuctionServ), "BindService")]
    public abstract partial class AuctionServBase
    {
      /// <summary>
      /// Creates a new auction for the owner
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::AuctionGrpcService.AuctionBasicReply> AuctionNew(global::AuctionGrpcService.AuctionNewRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Add a new auction for oher users
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::AuctionGrpcService.AuctionBasicReply> AuctionAdd(global::AuctionGrpcService.AuctionAddRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// get the list of auction and winners
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::AuctionGrpcService.AuctionGetReply> AuctionGet(global::AuctionGrpcService.AuctionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates a new bid
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::AuctionGrpcService.AuctionBasicReply> AuctionBidNew(global::AuctionGrpcService.AuctionBidRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Add a new bid for oher users
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::AuctionGrpcService.AuctionBasicReply> AuctionBidAdd(global::AuctionGrpcService.AuctionBidUsersRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(AuctionServBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_AuctionNew, serviceImpl.AuctionNew)
          .AddMethod(__Method_AuctionAdd, serviceImpl.AuctionAdd)
          .AddMethod(__Method_AuctionGet, serviceImpl.AuctionGet)
          .AddMethod(__Method_AuctionBidNew, serviceImpl.AuctionBidNew)
          .AddMethod(__Method_AuctionBidAdd, serviceImpl.AuctionBidAdd).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, AuctionServBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_AuctionNew, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::AuctionGrpcService.AuctionNewRequest, global::AuctionGrpcService.AuctionBasicReply>(serviceImpl.AuctionNew));
      serviceBinder.AddMethod(__Method_AuctionAdd, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::AuctionGrpcService.AuctionAddRequest, global::AuctionGrpcService.AuctionBasicReply>(serviceImpl.AuctionAdd));
      serviceBinder.AddMethod(__Method_AuctionGet, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::AuctionGrpcService.AuctionRequest, global::AuctionGrpcService.AuctionGetReply>(serviceImpl.AuctionGet));
      serviceBinder.AddMethod(__Method_AuctionBidNew, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::AuctionGrpcService.AuctionBidRequest, global::AuctionGrpcService.AuctionBasicReply>(serviceImpl.AuctionBidNew));
      serviceBinder.AddMethod(__Method_AuctionBidAdd, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::AuctionGrpcService.AuctionBidUsersRequest, global::AuctionGrpcService.AuctionBasicReply>(serviceImpl.AuctionBidAdd));
    }

  }
}
#endregion