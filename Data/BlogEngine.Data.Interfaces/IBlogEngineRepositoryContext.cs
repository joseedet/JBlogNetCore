using BlogEngine.DataModel.Entities;

using Microsoft.EntityFrameworkCore;

namespace BlogEngine.Data.Interfaces
{
    public interface IBlogEngineRepositoryContext : IBlogEngineDbContext
    {
        DbSet<Post> Posts { get; set; }
        DbSet<TEntity> Set<TEntity> () where TEntity : class;
    }
}
