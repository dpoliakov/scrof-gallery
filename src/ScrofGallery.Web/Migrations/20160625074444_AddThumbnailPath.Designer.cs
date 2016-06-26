using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ScrofGallery.Web.DataAccess;

namespace ScrofGallery.Web.Migrations
{
    [DbContext(typeof(GalleryDbContext))]
    [Migration("20160625074444_AddThumbnailPath")]
    partial class AddThumbnailPath
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rc2-20901")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ScrofGallery.Domain.Entities.GalleryItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.Property<string>("ThumbnailPath");

                    b.HasKey("Id");

                    b.ToTable("GalleryItems");
                });
        }
    }
}
