using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Internal;
using ScrofGallery.Domain.DataAccess;
using ScrofGallery.Domain.Entities;

namespace ScrofGallery.Web.DataAccess
{
    public class GalleryItemRepository : IGalleryItemRepository
    {
        private readonly GalleryDbContext _context;

        public GalleryItemRepository(GalleryDbContext context)
        {
            _context = context;
        }

        public List<GalleryItem> GetAllItems()
        {
            return _context.GalleryItems.ToList();
        }
    }
}
