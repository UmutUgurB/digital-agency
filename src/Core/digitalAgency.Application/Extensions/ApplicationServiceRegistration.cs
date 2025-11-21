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


            services.AddMediatR(assembly);


            services.AddAutoMapper(assembly);


            services.AddValidatorsFromAssembly(assembly);


            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            return services;    
        }
    }
}
