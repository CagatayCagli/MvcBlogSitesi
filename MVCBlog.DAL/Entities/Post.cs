using System;
using System.Collections.Generic;

namespace MVCBlogSitesi.DAL.Entities
{
    public class Post:BaseEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PostDate { get; set; }
        public string Description { get; set; }
        public string Summary { get; set; }
        public bool IsDeleted { get; set; }
        public int LikeCount { get; set; }
        public int DislikeCount { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }


        public virtual ICollection<Comments> Comments { get; set; }
        public virtual Users Users { get; set; }
        public virtual Category Category { get; set; }
    }
}
