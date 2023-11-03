namespace ShoeStore.Entities
{
    public class Orders
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string phone { get; set; }
        public string city { get; set; }
        public string Street { get; set; }
        public int BuildingNumber { get; set; }
        public Products Product { get; set; }
    }
}
