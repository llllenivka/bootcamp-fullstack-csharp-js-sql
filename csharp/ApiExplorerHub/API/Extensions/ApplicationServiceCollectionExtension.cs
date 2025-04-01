using API.Storage;

namespace API.Extensions;

public static class ApplicationServiceCollectionExtension
{
    public static IServiceCollection AddServicesCollection(this IServiceCollection services, ConfigurationManager configuration)
    {
        
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddControllers();
        var stringConnection = configuration.GetConnectionString("SqliteStringConnection");
        services.AddSingleton<IStorage>(new SqliteStorage(stringConnection));
        services.AddCors(opt =>
            opt.AddPolicy("CorsPolicy", policy =>
                {
                    policy.AllowAnyMethod()
                        .AllowAnyHeader()
                        .WithOrigins(configuration["client"]); // dotnet run http://localhost:3000
                }
            )
        );
        return services;
    }
}