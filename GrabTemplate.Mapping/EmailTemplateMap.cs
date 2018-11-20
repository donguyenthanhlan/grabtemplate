using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GrabTemplate.Domain;

namespace GrabTemplate.Mapping
{
    public class EmailTemplateMap : IEntityTypeConfiguration<EmailTemplate>
    {
        public void Configure(EntityTypeBuilder<EmailTemplate> builder)
        {
            // Primary Key
            builder.HasKey(t => t.Id);

            // Table & Column Mappings
            builder.ToTable("EmailTemplate");
            builder.Property(t => t.Id).HasColumnName("Id");
            builder.Property(t => t.Body).HasColumnName("Body");
            builder.Property(t => t.Subject).HasColumnName("Subject");
            builder.Property(t => t.LangId).HasColumnName("LangId");
            builder.Property(t => t.Name).HasColumnName("Name");

            builder.HasOne(x => x.Lang)
               .WithMany(x => x.EmailTemplates)
               .HasForeignKey(x => x.LangId);
        }
    }
}
