using System;

namespace ScrofGallery.Domain.Entities
{
    public class GalleryItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public double Price { get; set; }
    }
}
