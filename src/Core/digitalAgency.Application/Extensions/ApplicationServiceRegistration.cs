using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace digitalAgency.Application.Extensions
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationExtensions(this IServiceCollection services) 
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddAutoMapper(Assembly.GetExecutingAssembly());    
            return services;    
        }
    }
}
