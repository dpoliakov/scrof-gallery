using Microsoft.EntityFrameworkCore;
using ScrofGallery.Domain.Entities;

namespace ScrofGallery.Domain.DataAccess
{
    public class GalleryDbContext : DbContext
    {
        public DbSet<GalleryItem> GalleryItems { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer()
        //}
    }
}
