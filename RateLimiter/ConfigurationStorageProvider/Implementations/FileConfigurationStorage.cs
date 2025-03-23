using RateLimiter.Rules.Interfaces;

namespace RateLimiter.ConfigurationStorageProvider.Implementations
{
    internal class FileConfigurationStorage : IConfigurationStorageProvider<IRateLimiterRule>
    {
        public Task<List<IRateLimiterRule>?> LoadAsync(string endpoint)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveAsync(string key, List<IRateLimiterRule> values)
        {
            throw new NotImplementedException();
        }
    }
}
