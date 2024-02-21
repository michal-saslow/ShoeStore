using ShoeStore.Core.Entities;
using ShoeStore.Core.Repository;
using ShoeStore.Core.Services;

namespace ShoeStore.Service
{
    public class ServiceOrder : IOrderService
    {
        private readonly IOrderRepository _repositoryOrder;

        public ServiceOrder(IOrderRepository repositoryOrder)
        {
            _repositoryOrder = repositoryOrder;
        }
        public async Task<List<Order>> GetOrdersAsync()
        {
            return await _repositoryOrder.GetOrdersAsync();
        }
        public async Task<Order> AddAsync(Order order)
        { 
           return await _repositoryOrder.AddAsync(order);
        }
        
        public async Task<Order> UpdateAsync(int id, Order order)
        {
            return await _repositoryOrder.UpdateAsync(id, order);
        }
        public async Task DeleteAsync(int id)
        {
            await _repositoryOrder.DeleteAsync(id);
        }
        public async Task<Order> GetOrderByIdAsync(int id)
        {
            return await _repositoryOrder.GetOrderByIdAsync(id);
        } 
    }
}