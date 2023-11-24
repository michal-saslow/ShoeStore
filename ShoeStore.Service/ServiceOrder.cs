using ShoeStore.Core.Entities;
using ShoeStore.Core.Repository;
using ShoeStore.Core.Services;

namespace ShoeStore.Service
{
    public class ServiceOrder:IOrderService
    {
        private readonly IOrderRepository _repositoryOrder;
        
        
        public ServiceOrder(IOrderRepository repositoryOrder)
        {
            _repositoryOrder = repositoryOrder;
        }
        public List<Order> GetOrders()
        {
            return _repositoryOrder.GetOrders();
        }
        
        
    }
}