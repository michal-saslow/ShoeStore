namespace ShoeStore.Core.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int count { get; set; }
        public int providerId { get; set; }
        public Provider? Provider { get; set; }    
        public int productId { get; set; }
        public Product? Product { get; set; }
    }
}
