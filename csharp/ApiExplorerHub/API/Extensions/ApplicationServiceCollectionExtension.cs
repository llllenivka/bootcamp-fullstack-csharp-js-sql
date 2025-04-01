using API.DataContext;
using API.Seed;
using API.Storage;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions;

public static class ApplicationServiceCollectionExtension
{
    public static IServiceCollection AddServicesCollection(this IServiceCollection services, ConfigurationManager configuration)
    {
        
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddControllers();
        
        var stringConnection = configuration.GetConnectionString("SqliteStringConnection");
        services.AddDbContext<SqliteDbContext>(opt => opt.UseSqlite(stringConnection));
        
        services.AddScoped<IPaginationStorage, SqlitePaginationEfStorage>();
        services.AddScoped<IInitializer, SqliteEfFakerInitializer>();
        
        services.AddCors(opt =>
            opt.AddPolicy("CorsPolicy", policy =>
                {
                    policy.AllowAnyMethod()
                        .AllowAnyHeader()
                        .WithOrigins(configuration["client"]);
                }
            )
        );
        return services;
    }
}