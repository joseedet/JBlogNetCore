using BlogEngine.Data.Interfaces;

using System.Threading.Tasks;

namespace BlogEngine.Data.Repositories
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly IBlogEngineDbContext _dataContext;

        public UnitOfWork (IBlogEngineDbContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task ReloadEntities ()
        {
            await _dataContext.ReloadEntitiesAsync( );
        }

        public async Task<int> SaveChangesAsync ()
        {
           return await _dataContext.SaveChangesAsync();
        }
    }
}
