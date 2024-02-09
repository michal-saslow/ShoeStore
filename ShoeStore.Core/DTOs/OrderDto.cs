using ShoeStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStore.Core.DTOs
{
    public class OrderDto
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public int ProviderId { get; set; }
        public ProviderDto? Provider { get; set; }
        public int ProductId { get; set; }
        public ProductDto? Product { get; set; }
    }
}
