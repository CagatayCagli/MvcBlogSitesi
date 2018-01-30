using System.Data.Entity.ModelConfiguration;
using MVCBlogSitesi.DAL.Entities;

namespace MVCBlogSitesi.DAL.Mapping
{
    public class UsersMapping : EntityTypeConfiguration<Users>
    {
        public UsersMapping()
        {
            HasKey<int>(x => x.Id);

            Property(x => x.Id)
                .HasColumnName("Id")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.Name)
                .HasMaxLength(50)
                .IsUnicode()
                .IsRequired();

            Property(x => x.LastName)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(50);

            Property(x => x.Email)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(50);

            Property(x => x.Password)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode();

            Property(x => x.PasswordConfirm)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(10);

            Property(x => x.IsDeleted)
                .IsRequired();

            Property(x => x.IsAccepted)
                .IsRequired();

            Property(x => x.ProfilPic)
                .IsOptional()
                .IsUnicode();

            Property(x => x.Kod)
               .IsUnicode()
               .IsOptional();

            Property(x => x.RoleId)
                .IsRequired();
        }
    }
}
