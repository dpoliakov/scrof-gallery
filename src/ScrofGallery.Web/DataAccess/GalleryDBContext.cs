using Microsoft.EntityFrameworkCore;
using ScrofGallery.Web.Entities;

namespace ScrofGallery.Web.DataAccess
{
    public sealed class GalleryDbContext : DbContext
    {
        public GalleryDbContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<GalleryItem> GalleryItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            var connectionString = Startup.Configuration["DataSection:DomainDBConnection"];
            builder.UseSqlServer(connectionString);
        }
    }
}
