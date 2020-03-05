using ProductsAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsAPI.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int id);
        void InsertProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int productID);
    }
}
