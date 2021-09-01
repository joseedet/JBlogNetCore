using BlogEngine.Data.Interfaces;
using BlogEngine.DataModel.Entities;

namespace BlogEngine.Data.Repositories
{
    public class PostRepository:GenericRepository<Post,int>, IPostRepository
    {
        public PostRepository (IBlogEngineDbContext dbContext):base(dbContext)
        {

        }
    }
}
