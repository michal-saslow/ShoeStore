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
        public void PostProduct(Product product)
        {
            id++;
            product.Id = id;
            _repositoryProduct.PostProduct(product);
        }
        public void DeleteProduct(int id)
        {
            var product = _repositoryProduct.GetProducts().Find(x => x.Id == id);
            _repositoryProduct.DeleteProduct(product);
        }
        public Product GetProductById(int id)
        {
            return _repositoryProduct.GetProductById(id);
        }
        public void PutProduct(int id, Product p)
        {
            var product = _repositoryProduct.GetProducts().Find(x => x.Id == id);
            p.Id = product.Id;
            _repositoryProduct.PutProduct(product, p);
        }
        
    }
}
