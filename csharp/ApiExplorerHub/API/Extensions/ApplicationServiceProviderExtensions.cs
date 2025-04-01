using API.Seed;
using API.Storage;

namespace API.Extensions;

public static class ApplicationServiceProviderExtensions
{
    public static IServiceProvider AddCustomServices(this IServiceProvider services, IConfiguration configuration)
    {
        using var scope = services.CreateScope();
        
        var initializer = scope.ServiceProvider.GetRequiredService<IInitializer>();
        initializer.Initialize();
        
        return services;
    }
    
}