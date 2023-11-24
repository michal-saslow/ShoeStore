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
    }
}
