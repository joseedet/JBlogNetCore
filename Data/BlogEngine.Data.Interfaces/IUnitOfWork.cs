using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlogEngine.Data.Interfaces
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync ();
        Task ReloadEntities ();
    }
}
