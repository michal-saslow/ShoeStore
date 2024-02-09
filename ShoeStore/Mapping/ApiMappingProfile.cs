using AutoMapper;
using ShoeStore.Api.Entities;
using ShoeStore.Core.Entities;

namespace ShoeStore.Api.Mapping
{
    public class ApiMappingProfile:Profile
    {
       public ApiMappingProfile() {
            CreateMap<OrderPostModel, Order>();
            CreateMap<ProductPostModel, Product>();
            CreateMap<ProviderPostModel, Provider>();
        }
    }
}
