using System.Data.Entity.ModelConfiguration;
using MVCBlogSitesi.DAL.Entities;

namespace MVCBlogSitesi.DAL.Mapping
{
    public class CommentsMapping : EntityTypeConfiguration<Comments>
    {
        public CommentsMapping()
        {
            HasKey<int>(x => x.Id); // PK

            Property(x => x.Id)
                .HasColumnName("Id")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.CommentDate)
                .HasColumnName("CommentDate")
                .IsRequired();

            Property(x => x.UserId)
                .IsRequired();

            Property(x => x.PostId)
                .IsRequired();

            Property(x => x.IsDeleted)
                .IsRequired();

            Property(x => x.LikeCount)
                .IsOptional();

            Property(x => x.DislikeCount)
                .IsOptional();
        }
    }
}
