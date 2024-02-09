using AutoMapper;
using ShoeStore.Core.DTOs;
using ShoeStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStore.Core.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile() { 
            CreateMap<Order,OrderDto>().ReverseMap();
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Provider, ProviderDto>().ReverseMap();
        }
    }
}
