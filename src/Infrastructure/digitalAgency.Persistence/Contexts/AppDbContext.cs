using digitalAgency.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace digitalAgency.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Blog> Blogs { get; set; }  
        public DbSet<Slider> Sliders { get; set; }  
        public DbSet<Comment> Comments { get; set; }  
        public DbSet<Contact> Contact { get; set; }  
        public DbSet<Info> Infos { get; set; }  
        public DbSet<SocialMedia> SocialMedias { get; set; }  
        public DbSet<Service> Services { get; set; }  
        public DbSet<Reference> References { get; set; }  
        public DbSet<BlogCategory> BlogCategories { get; set; }  
        public DbSet<Tag> Tags { get; set; }  
        public DbSet<About> Abouts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);    
        }


    }
}
