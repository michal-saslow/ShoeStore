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
        Task<List<Provider>> GetProviderAsync();
        Task<Provider> AddAsync(Provider provider);
        Task DeleteAsync(int id);
        Task<Provider> GetProviderByIdAsync(int id);
        Task<Provider> UpdateAsync(int id, Provider provider);
    }
}
