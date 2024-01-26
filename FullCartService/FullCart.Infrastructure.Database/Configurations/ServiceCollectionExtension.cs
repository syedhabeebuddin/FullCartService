using FullCart.Infrastructure.Database.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FullCart.Infrastructure.Database.Configurations
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddFullCartDatabaseServices(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<FullCartDBContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:FullCartDB"]));
            return services;
        }
    }
}
