using Core;
using DAL.Abstract;
using DAL.Concrete.EntityFramework;
using DAL.Concrete.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DAL
{
    public static class ServiceRegistration
    {
        public static void AddDALService(this IServiceCollection serviceCollection)
        {
            //serviceCollection.AddDbContext<WinFormDBContext>(options =>
            //    options.UseSqlServer(Configuration.ConnectionString), ServiceLifetime.Singleton);

            serviceCollection.AddScoped<ICategoriesDal, EFCategoriesDal>();
        }
    }
}
