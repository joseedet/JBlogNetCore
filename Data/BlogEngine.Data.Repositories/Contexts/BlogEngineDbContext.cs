using BlogEngine.Data.Interfaces;
using BlogEngine.DataModel.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlogEngine.Data.Repositories.Contexts
{
    public class BlogEngineDbContext :DbContext, IBlogEngineRepositoryContext,IBlogEngineDbContext
    {
        public DbSet<Post> Posts { get; set; }

        public BlogEngineDbContext (DbContextOptions<BlogEngineDbContext> options):base(options)
        {
                
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
        }
        public async Task ReloadEntitiesAsync ()
        {
            var entities = base.ChangeTracker.Entries ( ).ToList ( );
            foreach(var entity in entities)
            {

                await ReloadEntitiesAsync( );
            }
        }



    }
}
