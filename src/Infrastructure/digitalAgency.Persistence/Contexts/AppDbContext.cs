using digitalAgency.Domain.Common;
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

            // Global Query Filter - Soft Delete için
            // Tüm sorgularda IsDeleted=false olan kayıtları getir
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                if (typeof(BaseEntity).IsAssignableFrom(entityType.ClrType))
                {
                    var parameter = Expression.Parameter(entityType.ClrType, "e");
                    var property = Expression.Property(parameter, nameof(BaseEntity.IsDeleted));
                    var filter = Expression.Lambda(Expression.Equal(property, Expression.Constant(false)), parameter);
                    
                    modelBuilder.Entity(entityType.ClrType).HasQueryFilter(filter);
                }
            }
        }

        /// <summary>
        /// SaveChanges override - Audit fields'i otomatik doldur
        /// </summary>
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            // ChangeTracker'dan değişen entity'leri al
            var entries = ChangeTracker.Entries<BaseEntity>();

            foreach (var entry in entries)
            {
                // TODO: Authentication eklendiğinde buradan current user bilgisi alınacak
                var currentUser = "System"; // Şimdilik default

                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.UtcNow;
                        entry.Entity.CreatedBy = currentUser;
                        entry.Entity.IsDeleted = false;
                        break;

                    case EntityState.Modified:
                        entry.Entity.UpdatedDate = DateTime.UtcNow;
                        entry.Entity.UpdatedBy = currentUser;
                        break;

                    case EntityState.Deleted:
                        // Hard delete yerine soft delete yap
                        entry.State = EntityState.Modified;
                        entry.Entity.SoftDelete(currentUser);
                        break;
                }
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}

// Expression kullanmak için gerekli namespace
namespace System.Linq.Expressions { }
