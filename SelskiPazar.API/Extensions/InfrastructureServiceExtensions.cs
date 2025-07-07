namespace SelskiPazar.API.Extensions
{
    public static class InfrastructureServiceExtensions
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            // Infrastructure Services
          /*  services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IFileStorageService, FileStorageService>();
            services.AddScoped<ICacheService, CacheService>();
            services.AddScoped<INotificationService, NotificationService>();
*/
            // HTTP Client
            services.AddHttpClient();

            return services;
        }
    }
}
