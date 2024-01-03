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
        Order Add(Order order);
        void Delete(int id);
        Order GetOrderById(int id);
        Order Update(int id, Order order);

    }
}
