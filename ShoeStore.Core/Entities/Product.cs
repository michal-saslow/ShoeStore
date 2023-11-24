namespace ShoeStore.Core.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int CountUnitsInStock { get; set; }
        public string? Company { get; set; }
    }
}
