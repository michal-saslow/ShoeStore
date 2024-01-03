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
        public Provider Add(Provider provider)
        {
            return _repositoryProvider.Add(provider);
        }
        public void Delete(int id)
        {
            _repositoryProvider.Delete(id);
        }
        public Provider GetProviderById(int id)
        {
            return _repositoryProvider.GetProviderById(id);
        }
        public Provider Update(int id, Provider p)
        {
            return _repositoryProvider.Update(id, p);
        }
    }
}
