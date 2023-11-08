namespace ShoeStore.Entities
{
    public class Orders
    {
        public int Id { get; set; }
        public Pruviders Pruviders { get; set; }    
        public Products Product { get; set; }
    }
}
