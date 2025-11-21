using digitalAgency.Application.Behaviors;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace digitalAgency.Application.Extensions
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationExtensions(this IServiceCollection services) 
        {
            var assembly = Assembly.GetExecutingAssembly();

            // MediatR
            services.AddMediatR(assembly);

            // AutoMapper
            services.AddAutoMapper(assembly);

            // FluentValidation - Tüm validator'ları otomatik register et
            services.AddValidatorsFromAssembly(assembly);

            // MediatR Pipeline Behaviors
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            return services;    
        }
    }
}
