using MVCBlogSitesi.Core.Concrete;
using MVCBlogSitesi.Repository.Repositories.Abstracts;
using System.Data.Entity;
using MVCBlogSitesi.DAL.Context;
using MVCBlogSitesi.DAL.Entities;

namespace MVCBlogSitesi.Repository.Repositories.Concretes
{
    public class CommentsRepository : EFRepositoryBase<Comments, ProjectContext>, ICommentsRepository
    {
        public CommentsRepository(DbContext Context) : base(Context)
        {
        }
    }
}
