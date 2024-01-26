using FullCart.Data.Repositories;
using FullCart.Data.Repositories.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace FullCart.Data.Configurations
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddFullCartDataServices(this IServiceCollection services)
        {
            services.AddScoped<IRoleRepository, RoleRepository>();
            return services;
        }
    }
}
