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
        public void PostProvider(Provider provider)
        {
            _repositoryProvider.PostProvider(provider);
        }
        public void DeleteProvider(int id)
        {
            var provider = _repositoryProvider.GetProviders().Find(x => x.Id == id);
            _repositoryProvider.DeleteProvider(provider);
        }
        public Provider GetProviderById(int id)
        {
            return _repositoryProvider.GetProviderById(id);
        }
        public void PutProvider(int id, Provider p)
        {
            var provider = _repositoryProvider.GetProviders().Find(x => x.Id == id);
            p.Id = provider.Id;
            _repositoryProvider.PutProvider(provider, p);
        }
    }
}
