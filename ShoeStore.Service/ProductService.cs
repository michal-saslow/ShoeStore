using ShoeStore.Core.Entities;
using ShoeStore.Core.Repository;
using ShoeStore.Core.Services;

namespace ShoeStore.Service
{
    public class ServiceProduct:IProductService
    {
        private readonly IProductRepository _repositoryProduct;
        public static int id = 0;
        public ServiceProduct(IProductRepository repositoryProduct)
        {
            _repositoryProduct=repositoryProduct;
        }
        public async Task<List<Product>> GetProductAsync()
        {
            return await _repositoryProduct.GetProductsAsync();
        }
        public async Task<Product> AddAsync(Product product)
        {
            return await _repositoryProduct.AddAsync(product);
        }
        public async Task DeleteAsync(int id)
        {
            await _repositoryProduct.DeleteAsync(id);
        }
        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _repositoryProduct.GetProductByIdAsync(id);
        }
        public async Task<Product> UpdateAsync(int id, Product p)
        {
           return await _repositoryProduct.UpdateAsync(id, p);
        }
        
    }
}
