using System.Collections.Generic;

namespace MVCBlogSitesi.DAL.Entities
{
    public class Role:BaseEntity
    {
        public int Id { get; set; }
        public string RoleName { get; set; }



        public virtual  ICollection<Users> Users{ get; set; }
    }
}
