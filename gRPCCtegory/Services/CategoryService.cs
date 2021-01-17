using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;

namespace gRPCCtegory.Services
{
    public class CategoryService : Category.CategoryBase
    {
        private readonly ILogger<CategoryService> _logger;
        private readonly List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "IPhone X", Category= "smart phones"},
            new Product { Id = 4, Name = "I3r3r", Category= "phones"},
            new Product { Id = 5, Name = "Macbook pro", Category= "laptops"},
            new Product { Id = 6, Name = "AirPods", Category= "headphones"},
        };
        public CategoryService(ILogger<CategoryService> logger)
        {
            _logger = logger;
        }
        public override Task<Product> getProductByCategory(CategoryName request, ServerCallContext context)
        {
            var product = products.Where(x => x.Category == request.Name).FirstOrDefault();
            return Task.FromResult(product);
        }

        /*  public override Task<CategoryName> ChangeCategoryNameById(ProductLookup request, ServerCallContext context)
          {
              var product = products.Where(x => x.Id == request.Id).FirstOrDefault();
          }*/
        public override async Task getAllProducts(AllProductsLookup request, IServerStreamWriter<Product> responseStream, ServerCallContext context)
        {
            foreach (var product in products)
            {
                await responseStream.WriteAsync(product);
            }
        }

    }
}
