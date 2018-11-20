using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using GrabTemplate.Domain;

namespace GrabTemplate.Mapping
{
    public class ColorMap : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            // Primary Key
            builder.HasKey(t => t.Id);

            // Table & Column Mappings
            builder.ToTable("Color");
            builder.Property(t => t.Id).HasColumnName("Id");
            builder.Property(t => t.CssClass).HasColumnName("CssClass");
            builder.Property(t => t.Value).HasColumnName("Value");
        }
    }
}
