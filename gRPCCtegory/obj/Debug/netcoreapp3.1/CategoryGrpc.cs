// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/category.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace gRPCCtegory {
  public static partial class Category
  {
    static readonly string __ServiceName = "Category";

    static readonly grpc::Marshaller<global::gRPCCtegory.CategoryName> __Marshaller_CategoryName = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::gRPCCtegory.CategoryName.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::gRPCCtegory.Product> __Marshaller_Product = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::gRPCCtegory.Product.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::gRPCCtegory.ProductLookup> __Marshaller_ProductLookup = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::gRPCCtegory.ProductLookup.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::gRPCCtegory.AllProductsLookup> __Marshaller_AllProductsLookup = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::gRPCCtegory.AllProductsLookup.Parser.ParseFrom);

    static readonly grpc::Method<global::gRPCCtegory.CategoryName, global::gRPCCtegory.Product> __Method_getProductByCategory = new grpc::Method<global::gRPCCtegory.CategoryName, global::gRPCCtegory.Product>(
        grpc::MethodType.Unary,
        __ServiceName,
        "getProductByCategory",
        __Marshaller_CategoryName,
        __Marshaller_Product);

    static readonly grpc::Method<global::gRPCCtegory.ProductLookup, global::gRPCCtegory.CategoryName> __Method_ChangeCategoryNameById = new grpc::Method<global::gRPCCtegory.ProductLookup, global::gRPCCtegory.CategoryName>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ChangeCategoryNameById",
        __Marshaller_ProductLookup,
        __Marshaller_CategoryName);

    static readonly grpc::Method<global::gRPCCtegory.AllProductsLookup, global::gRPCCtegory.Product> __Method_getAllProducts = new grpc::Method<global::gRPCCtegory.AllProductsLookup, global::gRPCCtegory.Product>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "getAllProducts",
        __Marshaller_AllProductsLookup,
        __Marshaller_Product);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::gRPCCtegory.CategoryReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Category</summary>
    [grpc::BindServiceMethod(typeof(Category), "BindService")]
    public abstract partial class CategoryBase
    {
      public virtual global::System.Threading.Tasks.Task<global::gRPCCtegory.Product> getProductByCategory(global::gRPCCtegory.CategoryName request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::gRPCCtegory.CategoryName> ChangeCategoryNameById(global::gRPCCtegory.ProductLookup request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task getAllProducts(global::gRPCCtegory.AllProductsLookup request, grpc::IServerStreamWriter<global::gRPCCtegory.Product> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CategoryBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_getProductByCategory, serviceImpl.getProductByCategory)
          .AddMethod(__Method_ChangeCategoryNameById, serviceImpl.ChangeCategoryNameById)
          .AddMethod(__Method_getAllProducts, serviceImpl.getAllProducts).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CategoryBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_getProductByCategory, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::gRPCCtegory.CategoryName, global::gRPCCtegory.Product>(serviceImpl.getProductByCategory));
      serviceBinder.AddMethod(__Method_ChangeCategoryNameById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::gRPCCtegory.ProductLookup, global::gRPCCtegory.CategoryName>(serviceImpl.ChangeCategoryNameById));
      serviceBinder.AddMethod(__Method_getAllProducts, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::gRPCCtegory.AllProductsLookup, global::gRPCCtegory.Product>(serviceImpl.getAllProducts));
    }

  }
}
#endregion
