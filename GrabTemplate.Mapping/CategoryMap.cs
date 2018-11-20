using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GrabTemplate.Domain;

namespace GrabTemplate.Mapping
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            // Primary Key
            builder.HasKey(t => t.Id);

            // Table & Column Mappings
            builder.ToTable("Category");
            builder.Property(t => t.Id).HasColumnName("Id");
            builder.Property(t => t.Name).HasColumnName("Name");
            builder.Property(t => t.ParentId).HasColumnName("ParentId");
            builder.Property(t => t.Icon).HasColumnName("Icon");
            builder.Property(t => t.Count).HasColumnName("Count");
            builder.Property(t => t.ListingImage).HasColumnName("ListingImage");

            builder.HasOne(x => x.Parent)
               .WithMany()
               .HasForeignKey(x => x.ParentId);
        }
    }
}
