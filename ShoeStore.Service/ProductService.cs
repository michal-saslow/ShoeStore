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
        public List<Product> GetProduct()
        {
            return _repositoryProduct.GetProducts();
        }
        public Product Add(Product product)
        {
            return _repositoryProduct.Add(product);
        }
        public void Delete(int id)
        {
            _repositoryProduct.Delete(id);
        }
        public Product GetProductById(int id)
        {
            return _repositoryProduct.GetProductById(id);
        }
        public Product Update(int id, Product p)
        {
           return _repositoryProduct.Update(id, p);
        }
        
    }
}
