﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GrabTemplate.Domain;

namespace GrabTemplate.Mapping
{
    public class LangMsgDetailMap : IEntityTypeConfiguration<LangMsgDetail>
    {
        public void Configure(EntityTypeBuilder<LangMsgDetail> builder)
        {
            // Primary Key
            builder.HasKey(t => t.Id);

            // Table & Column Mappings
            builder.ToTable("LangMsgDetail");
            builder.Property(t => t.Id).HasColumnName("Id");
            builder.Property(t => t.LangId).HasColumnName("LangId");
            builder.Property(t => t.Name).HasColumnName("Name");
            builder.Property(t => t.Value).HasColumnName("Value");

            builder.HasOne(x => x.Lang)
                .WithMany(x => x.LangMsgDetails)
                .HasForeignKey(x => x.LangId);
        }
    }
}
