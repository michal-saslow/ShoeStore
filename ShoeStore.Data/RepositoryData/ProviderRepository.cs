using Microsoft.EntityFrameworkCore;
using ShoeStore.Core.Entities;
using ShoeStore.Core.Repository;
using ShoeStore.Date;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStore.Data.RepositoryData
{
    public class ProviderRepository:IProviderRepository
    {

        private readonly DataContext _context;
        public ProviderRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Provider>> GetProvidersAsync()
        {
            return await _context.providers.ToListAsync();
        }
        public async Task<Provider> AddAsync(Provider provider)
        {
            _context.providers.Add(provider);
            await _context.SaveChangesAsync();
            return provider;
        }
        public async Task DeleteAsync(int id)
        {
            var provider = await GetProviderByIdAsync(id);
            _context.providers.Remove(provider);
            await _context.SaveChangesAsync();
        }
        public async Task<Provider> GetProviderByIdAsync(int id)
        {
            return await _context.providers.FindAsync(id);
        }
        public async Task<Provider> UpdateAsync(int id,Provider provider)
        {
            var existProvider = await GetProviderByIdAsync(id);
            existProvider.Name = provider.Name;
            existProvider.Phone=provider.Phone;
            existProvider.Email=provider.Email;
            await _context.SaveChangesAsync();
            return existProvider;
        }
    }
}
