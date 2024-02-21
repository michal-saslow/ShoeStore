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
        public async Task<List<Provider>> GetProviderAsync()
        {
            return await _repositoryProvider.GetProvidersAsync();
        }
        public async Task<Provider> AddAsync(Provider provider)
        {
            return await _repositoryProvider.AddAsync(provider);
        }
        public async Task DeleteAsync(int id)
        {
            await _repositoryProvider.DeleteAsync(id);
        }
        public async Task<Provider> GetProviderByIdAsync(int id)
        {
            return await _repositoryProvider.GetProviderByIdAsync(id);
        }
        public async Task<Provider> UpdateAsync(int id, Provider p)
        {
            return await _repositoryProvider.UpdateAsync(id, p);
        }
    }
}
