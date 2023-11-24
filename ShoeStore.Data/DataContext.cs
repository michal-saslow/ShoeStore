
using ShoeStore.Core.Entities;

namespace ShoeStore.Date
{
    public class DataContext
    {
        public  List<Order> orders { get; set; }
        public  List<Product> products { get; set; }
        public  List<Provider> providers { get; set; }
        public DataContext()
        {
            orders = new List<Order>();
            products = new List<Product>();
            providers = new List<Provider>();
        }
    }
}
