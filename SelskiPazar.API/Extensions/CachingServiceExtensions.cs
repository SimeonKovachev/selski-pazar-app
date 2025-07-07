using StackExchange.Redis;

namespace SelskiPazar.API.Extensions
{
    public static class CachingServiceExtensions
    {
        public static IServiceCollection AddCachingServices(this IServiceCollection services, IConfiguration configuration)
        {
            var redisConnectionString = configuration["Redis:ConnectionString"];

            if (!string.IsNullOrEmpty(redisConnectionString))
            {
                services.AddSingleton<IConnectionMultiplexer>(sp =>
                    ConnectionMultiplexer.Connect(redisConnectionString));
                services.AddStackExchangeRedisCache(options =>
                    options.Configuration = redisConnectionString);
            }
            else
            {
                services.AddMemoryCache();
            }

            return services;
        }
    }
}
