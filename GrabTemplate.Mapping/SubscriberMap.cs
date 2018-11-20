using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using GrabTemplate.Domain;

namespace GrabTemplate.Mapping
{
    public class SubscriberMap : IEntityTypeConfiguration<Subscriber>
    {
        public void Configure(EntityTypeBuilder<Subscriber> builder)
        {
            // Primary Key
            builder.HasKey(t => t.Id);

            // Table & Column Mappings
            builder.ToTable("Subscriber");
            builder.Property(t => t.Id).HasColumnName("Id");
            builder.Property(t => t.Email).HasColumnName("Email");
        }
    }
}
