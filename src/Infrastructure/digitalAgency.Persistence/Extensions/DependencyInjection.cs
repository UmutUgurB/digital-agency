using digitalAgency.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace digitalAgency.Persistence.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistenceExtensions(this IServiceCollection services,IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("SqlCon")));
            return services;    
        }
    }
}
