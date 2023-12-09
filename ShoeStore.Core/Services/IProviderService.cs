using ShoeStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStore.Core.Services
{
    public interface IProviderService
    {
        List<Provider> GetProvider();
        void PostProvider(Provider provider);
        void DeleteProvider(int id);
        Provider GetProviderById(int id);
        void PutProvider(int id, Provider provider);
    }
}
