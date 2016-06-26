using System.Collections.Generic;
using ScrofGallery.Web.Entities;

namespace ScrofGallery.Web.DataAccess
{
    public interface IGalleryItemRepository
    {
        List<GalleryItem> GetAllItems();
    }
}
