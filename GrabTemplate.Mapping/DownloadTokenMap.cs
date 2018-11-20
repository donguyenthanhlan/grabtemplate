using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using GrabTemplate.Domain;

namespace GrabTemplate.Mapping
{
    public class DownloadTokenMap : IEntityTypeConfiguration<DownloadToken>
    {
        public void Configure(EntityTypeBuilder<DownloadToken> builder)
        {
            // Primary Key
            builder.HasKey(t => t.Id);

            // Table & Column Mappings
            builder.ToTable("DownloadToken");
            builder.Property(t => t.Id).HasColumnName("Id");
            builder.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            builder.Property(t => t.Token).HasColumnName("Token");
        }
    }
}
