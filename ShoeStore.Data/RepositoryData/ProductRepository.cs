using ShoeStore.Core.Entities;
using ShoeStore.Core.Repository;
using ShoeStore.Date;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStore.Data.RepositoryData
{
    public class ProductRepository:IProductRepository
    {
        private readonly DataContext _context;
        public ProductRepository(DataContext context)
        {
            _context = context;
        }
        public List<Product> GetProducts()
        {
            return _context.products.ToList();
        }
        public void PostProduct(Product product)
        {
            _context.products.Add(product);
        }
        public void DeleteProduct(Product product)
        {
            _context.products.Remove(product);
        }
        public Product GetProductById(int id)
        {
            var product = _context.products.ToList().Find(x => x.Id == id);
            return product;
        }
        public void PutProduct(Product product, Product product2)
        {
            _context.products.Remove(product);
            _context.products.Add(product2);
        }
    }
}
