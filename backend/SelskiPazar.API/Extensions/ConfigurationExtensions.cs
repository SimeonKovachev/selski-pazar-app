using SelskiPazar.API.Configuration;

namespace SelskiPazar.API.Extensions
{
    public static class ConfigurationExtensions
    {
        public static IServiceCollection AddStronglyTypedConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
            services.Configure<DatabaseSettings>(configuration.GetSection(DatabaseSettings.SectionName));
            services.Configure<CacheSettings>(configuration.GetSection(CacheSettings.SectionName));
            services.Configure<FileStorageSettings>(configuration.GetSection(FileStorageSettings.SectionName));
            services.Configure<EmailSettings>(configuration.GetSection(EmailSettings.SectionName));

            return services;
        }
    }
}
