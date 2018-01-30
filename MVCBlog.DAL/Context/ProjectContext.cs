using System.Data.Entity;
using MVCBlogSitesi.DAL.Entities;
using MVCBlogSitesi.DAL.Mapping;

namespace MVCBlogSitesi.DAL.Context
{
    public class ProjectContext : DbContext
    {

        public
            ProjectContext()
            : base("name=MvcBlogDB")
        {
        }

        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryMapping());
            modelBuilder.Configurations.Add(new UsersMapping());
            modelBuilder.Configurations.Add(new RoleMapping());
            modelBuilder.Configurations.Add(new PostMapping());
            modelBuilder.Configurations.Add(new CommentsMapping());
        }

    }

}