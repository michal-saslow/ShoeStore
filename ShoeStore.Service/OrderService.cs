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
        public void PostOrder(Order order)
        {
            id++;
            order.Id = id;
            _repositoryOrder.PostOrder(order);
        }
        public void PutOrder(int id, Order o)
        {
            var order = _repositoryOrder.GetOrders().Find(x => x.Id == id);
            o.Id = order.Id;
            _repositoryOrder.PutOrder(order, o);
        }
        public void DeleteOrder(int id)
        {
            var order = _repositoryOrder.GetOrders().Find(x => x.Id == id);
            _repositoryOrder.DeleteOrder(order);
        }
        public Order GetOrderById(int id)
        {
            return _repositoryOrder.GetOrderById(id);
        } 
    }
}