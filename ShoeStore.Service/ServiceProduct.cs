using ShoeStore.Core.Entities;
using ShoeStore.Core.Repository;
using ShoeStore.Core.Services;

namespace ShoeStore.Service
{
    public class ServiceProduct:IProductService
    {
        private readonly IProductRepository _repositoryProduct;
        public ServiceProduct(IProductRepository repositoryProduct)
        {
            _repositoryProduct=repositoryProduct;
        }
        public List<Product> GetProduct()
        {
            return _repositoryProduct.GetProducts();
        }
    }
}
