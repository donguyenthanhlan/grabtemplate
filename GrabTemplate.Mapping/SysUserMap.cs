using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GrabTemplate.Domain;

namespace GrabTemplate.Mapping
{
    public class SysUserMap : IEntityTypeConfiguration<SysUser>
    {
        public void Configure(EntityTypeBuilder<SysUser> builder)
        {
            // Primary Key
            builder.HasKey(t => t.Id);

            // Table & Column Mappings
            builder.ToTable("SysUser");
            builder.Property(t => t.Id).HasColumnName("Id");
            builder.Property(t => t.Name).HasColumnName("Name");
            builder.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            builder.Property(t => t.Email).HasColumnName("Email");
            builder.Property(t => t.IsAdmin).HasColumnName("IsAdmin");
            builder.Property(t => t.Password).HasColumnName("Password");
        }
    }
}
