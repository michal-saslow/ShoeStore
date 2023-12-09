using ShoeStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStore.Core.Repository
{
    public interface IOrderRepository
    {
        List<Order> GetOrders();
        void PostOrder(Order order);
        void DeleteOrder(Order order);
        Order GetOrderById(int id);
        void PutOrder(Order order, Order order2);
    }
}
