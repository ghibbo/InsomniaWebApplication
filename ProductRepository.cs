using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsomniaWebApplication
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> products = new List<Product>();
        
        public ProductRepository()
        {
            products.Add(new Product
            {
                Id = 1,
                Code = "P0001",
                Name = "DELL XPS 15"
            });

            products.Add(new Product
            {
                Id = 2,
                Code = "P0002",
                Name = "Lenovo ThinkPad T480"
            });

            products.Add(new Product
            {
                Id = 3,
                Code = "P0003",
                Name = "Apple MacBook Pro"
            });
        }

        public Task<List<Product>> GetProducts()
        {
            return Task.FromResult(products);
        }

        public Task<Product> GetProduct(int id)
        {
            return Task.FromResult(products.
            Where(x => x.Id == id).SingleOrDefault());
        }

        public Task<bool> AddProduct(Product product)
        {
            products.Add(product);
            return Task.FromResult(true);
        }

        public Task<bool> DeleteProduct(int id)
        {
            products.Remove(products.
            Where(x => x.Id == id).SingleOrDefault());
            return Task.FromResult(true);
        }

    }
}
