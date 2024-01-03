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
        public Product Add(Product product)
        {
            _context.products.Add(product);
            _context.SaveChanges();
            return product;
        }
        public void Delete( int id)
        {
            var product= GetProductById(id);
            _context.products.Remove(product);
            _context.SaveChanges();
        }
        public Product GetProductById(int id)
        {
            return _context.products.Find(id);
        }
        public Product Update(int id, Product product)
        {
            var existProduct=GetProductById(id);
            existProduct.Name = product.Name;
            existProduct.CountUnitsInStock=product.CountUnitsInStock;
            existProduct.Company=product.Company;
            _context.SaveChanges();
            return existProduct;
        }
    }
}
