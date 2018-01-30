using System.Collections.Generic;

namespace MVCBlogSitesi.DAL.Entities
{
    public class Users:BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsAccepted { get; set; }
        public string ProfilPic { get; set; }
        public string Kod { get; set; }
        public int RoleId { get; set; }
        public bool RememberMe { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
    }
}
