using FullCart.Application.Contracts;
using FullCart.Application.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace FullCart.Application.Configurations
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddFullCartApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}
