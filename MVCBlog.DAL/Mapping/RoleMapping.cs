using System.Data.Entity.ModelConfiguration;
using MVCBlogSitesi.DAL.Entities;

namespace MVCBlogSitesi.DAL.Mapping
{
    public class RoleMapping:EntityTypeConfiguration<Role>
    {
        public RoleMapping()
        {
            HasKey<int>(x => x.Id);

            Property(x => x.Id)
                .HasColumnName("Id")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.RoleName)
                .IsUnicode()
                .IsRequired()
                .HasMaxLength(10);
        }
    }
}
