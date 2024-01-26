using FullCart.Application.Configurations;
using FullCart.Data.Configurations;
using FullCart.Infrastructure.Database.Configurations;

namespace FullCart.Api.Configurations
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddFullCartServices(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddFullCartDatabaseServices(Configuration)
                    .AddFullCartDataServices()
                    .AddFullCartApplicationServices()
                    ;
            return services;
        }
    }
}
