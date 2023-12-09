using ShoeStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStore.Core.Services
{
    public interface IOrderService
    {
        List<Order> GetOrders();
        void PostOrder(Order order);
        void DeleteOrder(int id);
        Order GetOrderById(int id);
        void PutOrder(int id, Order order);

    }
}
