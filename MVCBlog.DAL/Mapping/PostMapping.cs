using System.Data.Entity.ModelConfiguration;
using MVCBlogSitesi.DAL.Entities;

namespace MVCBlogSitesi.DAL.Mapping
{
    public class PostMapping:EntityTypeConfiguration<Post>
    {
        public PostMapping()
        {
            HasKey<int>(x => x.Id); // PK

            Property(x => x.Id)
                .HasColumnName("Id")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.Title)
                .HasMaxLength(100)
                .IsRequired()
                .IsUnicode();

            Property(x => x.PostDate)
                .IsRequired();

            Property(x => x.Description)
                .IsRequired()
                .IsUnicode();

            Property(x => x.UserId)
                .IsRequired();

            Property(x => x.CategoryId)
                .IsRequired();

            Property(x => x.Summary)
                .IsUnicode()
                .IsRequired()
                .HasMaxLength(200);

            Property(x => x.IsDeleted)
                .IsRequired();

            Property(x => x.LikeCount)
                .IsOptional();

            Property(x => x.DislikeCount)
                .IsOptional();
            

        }
    }
}
