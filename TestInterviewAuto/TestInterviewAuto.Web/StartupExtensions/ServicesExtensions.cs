using Microsoft.Extensions.DependencyInjection;
using TestInterviewAuto.Infrastructure.Repositories.CarBrandRepository;
using TestInterviewAuto.Infrastructure.Repositories.CarColorRepository;
using TestInterviewAuto.Infrastructure.Repositories.CarRepository;

namespace TestInterviewAuto.Web.StartupExtentions
{
    public static class ServicesExtensions
    {
        public static void RegisterAllRepositories(this IServiceCollection services)
        {
            services.AddTransient<ICarBrandRepository, CarBrandRepository>();
            services.AddTransient<ICarRepository, CarRepository>();
            services.AddTransient<ICarColorRepository, CarColorRepository>();
        }
    }
}