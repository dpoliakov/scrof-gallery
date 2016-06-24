using System.Collections.Generic;
using ScrofGallery.Domain.Entities;

namespace ScrofGallery.Domain.DataAccess
{
    public interface IGalleryItemRepository
    {
        List<GalleryItem> GetAllItems();
    }
}
