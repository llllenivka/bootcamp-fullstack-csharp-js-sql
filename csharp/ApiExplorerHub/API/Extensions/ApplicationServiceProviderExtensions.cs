using API.Seed;
using API.Storage;

namespace API.Extensions;

public static class ApplicationServiceProviderExtensions
{
    public static IServiceProvider AddCustomServices(this IServiceProvider services, IConfiguration configuration)
    {
        using var scope = services.CreateScope();
        
        var storage = scope.ServiceProvider.GetService<IStorage>();
        var db = storage as SqliteStorage;

        if (db != null)
        {
            string cs = configuration.GetConnectionString("SqliteStringConnection");
            new FakerInitializer(cs).Initialize();
        }
        
        return services;
    }
    
}