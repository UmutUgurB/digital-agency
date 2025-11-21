using digitalAgency.Application.Abstractions;
using digitalAgency.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace digitalAgency.Infrastructure.Extensions
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IPasswordHasher, PasswordHasher>();
            services.AddScoped<ICurrentUserService, CurrentUserService>();
            
          
            services.AddHttpContextAccessor();

            return services;
        }
    }
}

