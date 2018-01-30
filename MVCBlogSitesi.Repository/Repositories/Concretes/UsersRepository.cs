using MVCBlogSitesi.Core.Concrete;
using System.Data.Entity;
using MVCBlogSitesi.DAL.Context;
using MVCBlogSitesi.DAL.Entities;

namespace MVCBlogSitesi.Repository.Repositories.Concretes
{
    public class UsersRepository : EFRepositoryBase<Users, ProjectContext>
    {
        public UsersRepository(DbContext Context) : base(Context)
        {
        }
    }
}
