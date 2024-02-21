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
        Task<List<Order>> GetOrdersAsync();
        Task<Order> AddAsync(Order order);
        Task DeleteAsync(int id);
        Task<Order> GetOrderByIdAsync(int id);
        Task<Order> UpdateAsync(int id, Order order);

    }
}
