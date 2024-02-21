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
        Task<List<Provider>> GetProvidersAsync();
        Task<Provider> AddAsync(Provider provider);
        Task DeleteAsync(int id);
        Task<Provider> GetProviderByIdAsync(int id);
        Task<Provider> UpdateAsync(int id,Provider provider);
    }
}
