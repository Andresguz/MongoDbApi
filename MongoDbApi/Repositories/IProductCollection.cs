using System.Linq;
using System;
using MongoDB.Bson;
using System.Threading.Tasks;
using MongoDbApi.Models;
using System.Collections.Generic;

namespace MongoDbApi.Repositories
{
    public interface IProductCollection
    {
        Task InsertProduct(Product product);
        Task UpdateProduct(Product product);
        Task DeleteProduct(string id);

        Task<List<Product>> GetAllProducts();
        Task<Product> GetProductById(string id);
    }
}
