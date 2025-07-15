namespace SelskiPazar.API.Configuration
{
    public class CacheSettings
    {
        public const string SectionName = "Cache";

        public string? RedisConnectionString { get; set; }
        public int DefaultExpirationMinutes { get; set; } = 30;
        public bool UseDistributedCache { get; set; } = false;
    }
}
