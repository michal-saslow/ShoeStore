using ShoeStore.Core.Entities;
using ShoeStore.Core.Repository;
using ShoeStore.Core.Services;

namespace ShoeStore.Service
{
    public class ServiceOrder : IOrderService
    {
        private readonly IOrderRepository _repositoryOrder;

        public static int id=0;
        public ServiceOrder(IOrderRepository repositoryOrder)
        {
            _repositoryOrder = repositoryOrder;
        }
        public List<Order> GetOrders()
        {
            return _repositoryOrder.GetOrders();
        }
        public Order Add(Order order)
        { 
           return _repositoryOrder.Add(order);
        }
        
        public Order Update(int id, Order order)
        {
            return _repositoryOrder.Update(id, order);
        }
        public void Delete(int id)
        {
            _repositoryOrder.Delete(id);
        }
        public Order GetOrderById(int id)
        {
            return _repositoryOrder.GetOrderById(id);
        } 
    }
}