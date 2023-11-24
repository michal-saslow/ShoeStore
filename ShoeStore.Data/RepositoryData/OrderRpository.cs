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
            return _context.orders;
        }
    }
}
