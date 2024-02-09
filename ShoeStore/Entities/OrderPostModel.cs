using ShoeStore.Core.Entities;

namespace ShoeStore.Api.Entities
{
    public class OrderPostModel
    {
        public int Count { get; set; }
        public int ProviderId { get; set; }
        public int ProductId { get; set; }
       
    }
}
