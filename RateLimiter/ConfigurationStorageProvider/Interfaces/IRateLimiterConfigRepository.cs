using RateLimiter.Rules;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IRateLimiterConfigRepository
{
    Task<List<IRateLimiterRule>?> GetRulesConfigByEndpointAsync(string endpoint);
}
