using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GrabTemplate.Domain;

namespace GrabTemplate.Mapping
{
    public class TemplateColorMap : IEntityTypeConfiguration<TemplateColor>
    {
        public void Configure(EntityTypeBuilder<TemplateColor> builder)
        {
            // Primary Key
            builder.HasKey(t => new { t.TemplateId, t.ColorId });

            // Table & Column Mappings
            builder.ToTable("TemplateColor");

            builder.HasOne(x => x.Template)
                .WithMany(x => x.TemplateColors)
                .HasForeignKey(x => x.TemplateId);

            builder.HasOne(x => x.Color)
                .WithMany(x => x.TemplateColors)
                .HasForeignKey(x => x.ColorId);
        }
    }
}
