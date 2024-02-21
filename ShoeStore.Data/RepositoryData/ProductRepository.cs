using Microsoft.EntityFrameworkCore;
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
        public async Task<List<Product>> GetProductsAsync()
        {
            return await _context.products.ToListAsync();
        }
        public async Task<Product> AddAsync(Product product)
        {
            _context.products.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }
        public async Task DeleteAsync( int id)
        {
            var product= await GetProductByIdAsync(id);
            _context.products.Remove(product);
            await _context.SaveChangesAsync();
        }
        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _context.products.FindAsync(id);
        }
        public async Task<Product> UpdateAsync(int id, Product product)
        {
            var existProduct=await GetProductByIdAsync(id);
            existProduct.Name = product.Name;
            existProduct.CountUnitsInStock=product.CountUnitsInStock;
            existProduct.Company=product.Company;
            await _context.SaveChangesAsync();
            return existProduct;
        }
    }
}
