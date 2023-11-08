using ShoeStore.Entities;

namespace ShoeStore
{
    public class DataContext
    {
        public  List<Order> orders { get; set; }
        public  List<Product> products { get; set; }
        public  List<Provider> pruviders { get; set; }
        public DataContext()
        {
            orders = new List<Order>();
            products = new List<Product>();
            pruviders = new List<Provider>();
        }
    }
}
