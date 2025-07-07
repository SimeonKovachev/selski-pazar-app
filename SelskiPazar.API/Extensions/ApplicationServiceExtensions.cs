using FluentValidation;

namespace SelskiPazar.API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
           /* // AutoMapper
            services.AddAutoMapper(typeof(AutoMapperProfile));

            // FluentValidation
            services.AddFluentValidationAutoValidation();
            services.AddFluentValidationClientsideAdapters();
            services.AddValidatorsFromAssemblyContaining<Program>();

            // Application Services
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IListingService, ListingService>();
            services.AddScoped<IMessageService, MessageService>();
            services.AddScoped<IFavoriteService, FavoriteService>();
            services.AddScoped<ISearchService, SearchService>();

            // Repositories
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IListingRepository, ListingRepository>();
            services.AddScoped<IMessageRepository, MessageRepository>();
            services.AddScoped<IFavoriteRepository, FavoriteRepository>();
            services.AddScoped<IReviewRepository, ReviewRepository>();*/

            return services;
        }
    }
}
