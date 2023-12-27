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
        Provider Add(Provider provider);
        void Delete(int id);
        Provider GetProviderById(int id);
        Provider Update(int id, Provider provider);
    }
}
