namespace SelskiPazar.API.Configuration
{
    public class DatabaseSettings
    {
        public const string SectionName = "Database";

        public string ConnectionString { get; set; } = string.Empty;
        public int MaxRetryCount { get; set; } = 3;
        public int MaxRetryDelay { get; set; } = 5;
        public bool EnableSensitiveDataLogging { get; set; } = false;
    }
}
