using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using GrabTemplate.Domain;

namespace GrabTemplate.Mapping
{
    public class OriginalThemeMap : IEntityTypeConfiguration<OriginalTheme>
    {
        public void Configure(EntityTypeBuilder<OriginalTheme> builder)
        {
            // Primary Key
            builder.HasKey(t => t.Id);

            // Table & Column Mappings
            builder.ToTable("OriginalTheme");
            builder.Property(t => t.Id).HasColumnName("Id");
            builder.Property(t => t.Name).HasColumnName("Name");
            builder.Property(t => t.Image).HasColumnName("Image");
            builder.Property(t => t.ParentId).HasColumnName("ParentId");
            builder.Property(t => t.Count).HasColumnName("Count");
        }
    }
}
