using ShoeStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStore.Core.Repository
{
    public interface IProviderRepository
    {
        List<Provider> GetProviders();
        void PostProvider(Provider provider);
        void DeleteProvider(Provider provider);
        Provider GetProviderById(int id);
        void PutProvider(Provider provider, Provider provider2);
    }
}
