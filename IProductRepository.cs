using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsomniaWebApplication
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProducts();
        Task<Product> GetProduct(int id);
        Task<bool> AddProduct(Product product);
        Task<bool> DeleteProduct(int id);
    }
}
