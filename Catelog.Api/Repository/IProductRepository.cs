using Catelog.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catelog.Api.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();

        Product GetProductById(int productId);

        void InsertProduct(Product product);

        void UpdateProduct(Product product);

        void DeleteProduct(int productId);
    }
}
