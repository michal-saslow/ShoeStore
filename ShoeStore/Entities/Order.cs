namespace ShoeStore.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public Provider? Provider { get; set; }    
        public Product? Product { get; set; }
    }
}
