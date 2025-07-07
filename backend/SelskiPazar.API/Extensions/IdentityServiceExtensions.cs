using Microsoft.AspNetCore.Identity;
using SelskiPazar.Infrastructure.Data;

namespace SelskiPazar.API.Extensions
{
    public static class IdentityServiceExtensions
    {
       /* public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddIdentity<User, IdentityRole<int>>(options =>
            {
                ConfigurePasswordOptions(options);
                ConfigureUserOptions(options);
                ConfigureLockoutOptions(options);
            })
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders();

            return services;
        }*/

        private static void ConfigurePasswordOptions(IdentityOptions options)
        {
            options.Password.RequireDigit = true;
            options.Password.RequiredLength = 8;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireUppercase = true;
            options.Password.RequireLowercase = true;
        }

        private static void ConfigureUserOptions(IdentityOptions options)
        {
            options.User.RequireUniqueEmail = true;
            options.SignIn.RequireConfirmedEmail = false;
        }

        private static void ConfigureLockoutOptions(IdentityOptions options)
        {
            options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(15);
            options.Lockout.MaxFailedAccessAttempts = 5;
            options.Lockout.AllowedForNewUsers = true;
        }
    }
}
