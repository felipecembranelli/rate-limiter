using RateLimiter.Rules;
using RateLimiter.Rules.Interfaces;

public interface IConfigurationStorageProvider<T> where T : IRateLimiterRule
{
    Task<bool> SaveAsync(string key, List<T> values);
    Task<List<T>?> LoadAsync(string endpoint);
}