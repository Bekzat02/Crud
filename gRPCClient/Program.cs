using Grpc.Net.Client;
using gRPCCtegory;
using System;
using System.Threading.Tasks;

namespace gRPCClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.Write("Enter category of product: ");
            string input = Console.ReadLine();
            
            var channel = GrpcChannel.ForAddress("https://localhost:5001");

            var client = new Category.CategoryClient(channel);

            var reply = await client.getProductByCategoryAsync(new CategoryName { Name = input });
            
            Console.WriteLine($"{reply.Name} ");
            
            Console.ReadLine();
        }
    }
}
