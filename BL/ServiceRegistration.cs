using BL.Abstract;
using BL.Concrete;
using DAL.Abstract;
using Microsoft.Extensions.DependencyInjection;

namespace BL
{
    public static class ServiceRegistration
    {
        public static void AddBussinessService(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ICategoriesService, CategoriesService>();
        }
    }
}
