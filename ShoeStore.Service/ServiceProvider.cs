using ShoeStore.Core.Entities;
using ShoeStore.Core.Repository;
using ShoeStore.Core.Services;

namespace ShoeStore.Service
{
    public class ServiceProvider : IProviderService
    {
        private readonly IProviderRepository _repositoryProvider;
        public ServiceProvider(IProviderRepository repositoryProvider)
        {
            _repositoryProvider = repositoryProvider;
        }
        public List<Provider> GetProvider()
        {
            return _repositoryProvider.GetProviders();
        }
    }
}
