using digitalAgency.Application.Abstractions;
using digitalAgency.Application.Repositories;
using digitalAgency.Persistence.Contexts;
using digitalAgency.Persistence.Repositories;
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
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<ISliderRepository, SliderRepository>();
            services.AddScoped<IAboutRepository, AboutRepository>();    
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICommentRepository, CommentRepository>();    
            services.AddScoped<IContactRepository, ContactRepository>();    
            services.AddScoped<IInfoRepository, InfoRepository>();    
            services.AddScoped<IReferenceRepository, ReferenceRepository>();    
            services.AddScoped<IServiceRepository, ServiceRepository>();    
            services.AddScoped<ISocialMediaRepository, SocialMediaRepository>();    
            return services;    
        }
    }
}
