using System;

namespace MVCBlogSitesi.DAL.Entities
{
    public class Comments:BaseEntity
    {
        public int Id { get; set; }
        public DateTime CommentDate { get; set; }
        public bool IsDeleted { get; set; }
        public int LikeCount { get; set; }
        public int DislikeCount { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }

        public virtual Users Users { get; set; }
        public virtual Post Post { get; set; }
    }
}
