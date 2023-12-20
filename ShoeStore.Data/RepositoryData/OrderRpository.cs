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
        public void PostOrder(Order order)
        {
            _context.orders.Add(order);
        }
        public void DeleteOrder(Order order)
        {
            _context.orders.Remove(order);
        }
        public void PutOrder(Order order, Order order2)
        {
            _context.orders.Remove(order);
            _context.orders.Add(order2);
        }
        public Order GetOrderById(int id)
        {
            var order = _context.orders.ToList().Find(x => x.Id == id);
            return order;
        }
    }
}
