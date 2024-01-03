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
        public List<Provider> GetProviders()
        {
            return _context.providers.ToList();
        }
        public Provider Add(Provider provider)
        {
            _context.providers.Add(provider);
            _context.SaveChanges();
            return provider;
        }
        public void Delete(int id)
        {
            var provider = GetProviderById(id);
            _context.providers.Remove(provider);
            _context.SaveChanges();
        }
        public Provider GetProviderById(int id)
        {
            return _context.providers.Find(id);
        }
        public Provider Update(int id,Provider provider)
        {
            var existProvider = GetProviderById(id);
            existProvider.Name = provider.Name;
            existProvider.Phone=provider.Phone;
            existProvider.Email=provider.Email;
            _context.SaveChanges();
            return existProvider;
        }
    }
}
