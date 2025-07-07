using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SelskiPazar.Infrastructure.Data;
using Serilog;

namespace SelskiPazar.API.Extensions
{
    public static class PipelineExtensions
    {
        public static WebApplication ConfigurePipeline(this WebApplication app, IWebHostEnvironment environment)
        {
            // Development specific middleware
            if (environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "SelskiPazar API v1");
                    c.RoutePrefix = string.Empty;
                });
            }
            else
            {
                app.UseHsts();
            }

            // Security middleware
            //app.UseSecurityHeaders();
            //app.UseErrorHandling();

            // Core middleware
            app.UseHttpsRedirection();
            app.UseResponseCompression();
            app.UseCors("AllowSpecificOrigins");
            app.UseRateLimiter();

            // Authentication & Authorization
            //app.UseAuthentication();
            app.UseAuthorization();

            // Logging
            app.UseSerilogRequestLogging();

            // Health checks
            //app.UseHealthChecks("/health");

            // Endpoints
            app.MapControllers();
            //app.MapHub<MessageHub>("/messageHub");

            return app;
        }

        public static async Task<WebApplication> InitializeDatabaseAsync(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var services = scope.ServiceProvider;

            try
            {
                var context = services.GetRequiredService<ApplicationDbContext>();
                //var userManager = services.GetRequiredService<UserManager<User>>();
                //var roleManager = services.GetRequiredService<RoleManager<IdentityRole<int>>>();

                // Apply migrations
                await context.Database.MigrateAsync();

                // Seed data
                //await DataSeeder.SeedAsync(context, userManager, roleManager);

                Log.Information("Database initialized successfully");
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "An error occurred while migrating or seeding the database");
                throw;
            }

            return app;
        }
    }
}
