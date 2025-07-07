using SelskiPazar.API.Extensions;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Configure Serilog early
builder.Host.UseSerilog((context, configuration) =>
    configuration.ReadFrom.Configuration(context.Configuration));

// Add services to the container.
builder.Services
    .AddDatabaseServices(builder.Configuration)
    .AddApiServices()
    .AddCachingServices(builder.Configuration)
    .AddSecurityServices(builder.Configuration);

var app = builder.Build();

// Configure pipeline using extension methods
app.ConfigurePipeline(builder.Environment);

// Initialize database
await app.InitializeDatabaseAsync();

// Run application
try
{
    Log.Information("Starting SelskiPazar API");
    await app.RunAsync();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Application terminated unexpectedly");
}
finally
{
    Log.CloseAndFlush();
}
