namespace ShoeStore.Core.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public int ProviderId { get; set; }
        public Provider? Provider { get; set; }    
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
