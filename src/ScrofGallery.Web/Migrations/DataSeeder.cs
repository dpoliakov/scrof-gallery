using System;
using System.Globalization;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using ScrofGallery.Web.DataAccess;
using ScrofGallery.Web.Entities;

namespace ScrofGallery.Web.Migrations
{
    public static class DataSeeder
    {
        // TODO: Move this code when seed data is implemented in EF 7

        /// <summary>
        /// This is a workaround for missing seed data functionality in EF 7.0-rc1
        /// More info: https://github.com/aspnet/EntityFramework/issues/629
        /// </summary>
        /// <param name="app">
        /// An instance that provides the mechanisms to get instance of the database context.
        /// </param>
        public static void SeedData(this IApplicationBuilder app)
        {
            var context = (GalleryDbContext)app.ApplicationServices.GetService(typeof(GalleryDbContext));

            if (context.GalleryItems.Any())
            {
                return;
            }

            AddGalleryItem(context, "Mona Lisa", "half - length portrait of a woman", "1/1/1517", 100500, "~/images/GalleryContent/Previews/mona-lisa.jpg");
            AddGalleryItem(context, "Temptation of St. Anthony", " oil on canvas", "1/1/1945", 100500, "~/images/GalleryContent/Previews/salvador-dali-the-temptation-of-st--anthony.jpg");

            context.SaveChanges();
        }

        private static void AddGalleryItem(GalleryDbContext context, string name, string description, string creationDate, long price, string thumbnailPath)
        {
            var galleryItem = new GalleryItem
            {
                Id = Guid.NewGuid(),
                Name = name,
                Description = description,
                CreationDate = DateTime.ParseExact(creationDate, "%M/%d/yyyy", CultureInfo.InvariantCulture),
                Price = price,
                ThumbnailPath = thumbnailPath
            };

            context.GalleryItems.Add(galleryItem);
        }
    }
}
