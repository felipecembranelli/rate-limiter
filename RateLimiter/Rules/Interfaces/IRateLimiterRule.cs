using RateLimiter.Core;

namespace RateLimiter.Rules.Interfaces
{
    public interface IRateLimiterRule
    {
        public Task<bool> IsRequestAllowedAsync(ClientRequestContext context);
    }

}
