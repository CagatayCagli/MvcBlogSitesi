using System.Data.Entity.ModelConfiguration;
using MVCBlogSitesi.DAL.Entities;

namespace MVCBlogSitesi.DAL.Mapping
{
    public class CategoryMapping : EntityTypeConfiguration<Category>
    {
        public CategoryMapping()
        {
            HasKey<int>(x => x.Id); // PK

            Property(x => x.Id)
                .HasColumnName("Id")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.Name)
                .IsRequired()
                .IsUnicode()
                .HasMaxLength(50);

            Property(x => x.Description)
                .IsOptional()
                .IsUnicode()
                .HasMaxLength(50);

            Property(x => x.PostCount)
                .IsRequired();
            
        }
    }
}
