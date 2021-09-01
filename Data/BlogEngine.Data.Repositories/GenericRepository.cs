using BlogEngine.Data.Interfaces;

using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogEngine.Data.Repositories
{
    public class GenericRepository<TEntity, TKey> : IGenericRepository<TEntity, TKey> where TEntity : class
    {
        private IBlogEngineDbContext _dataContext;
        private DbSet<TEntity> dbSet;
        public GenericRepository (IBlogEngineDbContext dataContext)
        {
            _dataContext = dataContext;
            dbSet = _dataContext.Set<TEntity>( );
        }
        public virtual async Task<List<TEntity>> GetAsync ()
        {
            return await dbSet.ToListAsync( );
        }
    }
}
