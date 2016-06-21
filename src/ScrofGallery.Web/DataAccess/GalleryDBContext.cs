using Microsoft.EntityFrameworkCore;
using ScrofGallery.Domain.Entities;

namespace ScrofGallery.Web.DataAccess
{
    public class GalleryDbContext : DbContext
    {
        public DbSet<GalleryItem> GalleryItems { get; set; }
    }
}
