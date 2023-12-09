using ShoeStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStore.Core.Services
{
    public interface IProductService
    {
        List<Product> GetProduct();
        void PostProduct(Product product);
        void DeleteProduct(int id);
        Product GetProductById(int id);
        void PutProduct(int id, Product product);
    }
}
