using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using GrabTemplate.Domain;

namespace GrabTemplate.Mapping
{
    public class LangMap : IEntityTypeConfiguration<Lang>
    {
        public void Configure(EntityTypeBuilder<Lang> builder)
        {
            // Primary Key
            builder.HasKey(t => t.Id);

            // Table & Column Mappings
            builder.ToTable("Lang");
            builder.Property(t => t.Id).HasColumnName("Id");
            builder.Property(t => t.Image).HasColumnName("Image");
            builder.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
