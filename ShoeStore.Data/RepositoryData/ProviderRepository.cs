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
            return _context.providers;
        }
        public void PostProvider(Provider provider)
        {
            _context.providers.Add(provider);
        }
        public void DeleteProvider(Provider provider)
        {
            _context.providers.Remove(provider);
        }
        public Provider GetProviderById(int id)
        {
            var provider = _context.providers.Find(x => x.Id == id);
            return provider;
        }
        public void PutProvider(Provider provider, Provider provider2)
        {
            _context.providers.Remove(provider);
            _context.providers.Add(provider2);
        }
    }
}
