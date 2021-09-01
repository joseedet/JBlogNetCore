using BlogEngine.Data.Interfaces;
using BlogEngine.Data.Repositories;
using BlogEngine.Data.Repositories.Contexts;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BlogEngine.Infrastructure.DependencyInjection
{
    public class RepositoryModule
    {
        public static void Configure(IServiceCollection  service, IConfiguration configure)
        {
            var connectionString = configure.GetConnectionString("DefaultConnection");

            service.AddDbContext<BlogEngineDbContext>(
                options =>options.UseSqlite(
                    connectionString,sqlLiteOptions=>sqlLiteOptions.MigrationsAssembly("BlogEngine.Data.Repositories"))
            );

            service.AddScoped<IBlogEngineRepositoryContext, BlogEngineDbContext>( );
            service.AddTransient<IUnitOfWork>(unit => new UnitOfWork(unit.GetService<IBlogEngineRepositoryContext>( )));

            service.AddTransient<IPostRepository, PostRepository>( );

        }
    }
}
