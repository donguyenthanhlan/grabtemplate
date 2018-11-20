using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using GrabTemplate.Domain;

namespace GrabTemplate.Mapping
{
    public class TemplateMap : IEntityTypeConfiguration<Template>
    {
        public void Configure(EntityTypeBuilder<Template> builder)
        {
            // Primary Key
            builder.HasKey(t => t.Id);

            // Table & Column Mappings
            builder.ToTable("Template");
            builder.Property(t => t.Id).HasColumnName("Id");
            builder.Property(t => t.CategoryId).HasColumnName("CategoryId");
            builder.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            builder.Property(t => t.Description).HasColumnName("Description");
            builder.Property(t => t.ListingImage).HasColumnName("ListingImage");
            builder.Property(t => t.DetailImages).HasColumnName("DetailImages");
            builder.Property(t => t.SlideImage).HasColumnName("SlideImage");
            builder.Property(t => t.Title).HasColumnName("Title");
            builder.Property(t => t.AuthorId).HasColumnName("AuthorId");
            builder.Property(t => t.SourceId).HasColumnName("SourceId");
            builder.Property(t => t.Rate).HasColumnName("Rate");
            builder.Property(t => t.ReviewCount).HasColumnName("ReviewCount");
            builder.Property(t => t.ShortDescription).HasColumnName("ShortDescription");
            builder.Property(t => t.DemoUrl).HasColumnName("DemoUrl");
            builder.Property(t => t.BuyUrl).HasColumnName("BuyUrl");
            builder.Property(t => t.OriginalThemeId).HasColumnName("OriginalThemeId");
            builder.Property(t => t.CssFramework).HasColumnName("CssFramework");
            builder.Property(t => t.ViewCount).HasColumnName("ViewCount");
            builder.Property(t => t.DownloadCount).HasColumnName("DownloadCount");
            builder.Property(t => t.IsResponsive).HasColumnName("IsResponsive");
            builder.Property(t => t.Tags).HasColumnName("Tags");
            builder.Property(t => t.IsBestSelling).HasColumnName("IsBestSelling");
            builder.Property(t => t.DownloadUrl).HasColumnName("DownloadUrl");
            builder.Property(t => t.ShortDownloadUrl).HasColumnName("ShortDownloadUrl");
            builder.Property(t => t.Palette).HasColumnName("Palette");

            builder.HasOne(x => x.Category)
                .WithMany(x => x.Templates)
                .HasForeignKey(x => x.CategoryId);

            builder.HasOne(x => x.Source)
                .WithMany(x => x.Templates)
                .HasForeignKey(x => x.SourceId);

            builder.HasOne(x => x.Author)
                .WithMany(x => x.Templates)
                .HasForeignKey(x => x.AuthorId);

            builder.HasOne(x => x.OriginalTheme)
                .WithMany(x => x.Templates)
                .HasForeignKey(x => x.OriginalThemeId);
        }
    }
}
