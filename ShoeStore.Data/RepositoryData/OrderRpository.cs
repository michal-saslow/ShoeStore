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
    public class OrderRpository:IOrderRepository
    {
        private readonly DataContext _context;
        public OrderRpository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Order>> GetOrdersAsync()
        {
            return await _context.orders.ToListAsync();
        }
        public async Task<Order> AddAsync(Order order)
        {
            _context.orders.Add(order);
            await _context.SaveChangesAsync();
            return order;
        }
        public async Task DeleteAsync(int id)
        {
            var order = await GetOrderByIdAsync(id);
            _context.orders.Remove(order);
            await _context.SaveChangesAsync();
        }
        public async Task<Order> UpdateAsync(int id, Order order)
        {
            var existOrder= await GetOrderByIdAsync(id);
            existOrder.Product=order.Product;
            existOrder.Provider=order.Provider;
            await _context.SaveChangesAsync();
            return existOrder;
        }
        public async Task<Order> GetOrderByIdAsync(int id)
        {
            return  await _context.orders.FirstAsync(u => u.Id == id);
        }

    }
}
