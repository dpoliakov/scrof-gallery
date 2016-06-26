using System;

namespace ScrofGallery.Web.Entities
{
    public class GalleryItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public double Price { get; set; }
        public string ThumbnailPath { get; set; }
    }
}
