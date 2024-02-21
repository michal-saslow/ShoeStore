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
        Task<List<Product>> GetProductsAsync();
        Task<Product> AddAsync(Product product);
        Task DeleteAsync(int id);
        Task<Product> GetProductByIdAsync(int id);
        Task<Product> UpdateAsync(int id, Product product);
    }
}
