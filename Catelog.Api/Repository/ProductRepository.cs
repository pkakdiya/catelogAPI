using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catelog.Api.DBContexts;
using Catelog.Api.Models;

namespace Catelog.Api.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _productContext;
        
        public ProductRepository(ProductContext dBContexts)
        {
            _productContext = dBContexts;
        }

        public void DeleteProduct(int productId)
        {
           var product = _productContext.Products.Find(productId);
            _productContext.Remove(product);
            _productContext.SaveChanges();
        }

        public Product GetProductById(int productId)
        {
            return _productContext.Products.Find(productId);
        }
         
        public IEnumerable<Product> GetProducts()
        {
            return _productContext.Products.ToList();
        }

        public void InsertProduct(Product product)
        {
            _productContext.Add(product);
            _productContext.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            _productContext.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _productContext.SaveChanges();
        }
    }
}
