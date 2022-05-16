using FizzBuzzWeb.Interfaces;
using FizzBuzzWeb.Pages;
using FizzBuzzWeb.Repositories;
using FizzBuzzWeb.Services;

namespace FizzBuzzWeb
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddProjectService(this IServiceCollection services)
        {
            services.AddTransient<IPersonService,PersonService>();
            services.AddTransient<IPersonRepository,PersonRepository>();
            return services;
        }


    }
}
