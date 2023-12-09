using ShoeStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStore.Core.Repository
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
        void PostProduct(Product product);
        void DeleteProduct(Product product);
        Product GetProductById(int id);
        void PutProduct(Product product, Product product2);
    }
}
