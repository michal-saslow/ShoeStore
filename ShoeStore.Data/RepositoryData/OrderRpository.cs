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
        public List<Order> GetOrders()
        {
            return _context.orders.ToList();
        }
        public Order Add(Order order)
        {
            _context.orders.Add(order);
            _context.SaveChanges();
            return order;
        }
        public void Delete(int id)
        {
            var order = GetOrderById(id);
            _context.orders.Remove(order);
            _context.SaveChanges();
        }
        public Order Update(int id, Order order)
        {
            var existOrder=GetOrderById(id);
            existOrder.Product=order.Product;
            existOrder.Provider=order.Provider;
            _context.SaveChanges();
            return existOrder;
        }
        public Order GetOrderById(int id)
        {
            return _context.orders.Find(id);
        }
    }
}
