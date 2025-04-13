using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RH.Domain.Interface;
using RH.MySQL.Repositories;

namespace RH.MySQL
{
    public static class AddRepositorySetup
    {
        public static IServiceCollection AddRepository(this IServiceCollection services, IConfiguration configuration)
        {

            // Registra os repositórios genéricos como tipos abertos
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            // Registra o repositório específico para IBeneficioColaboradorRepository
            services.AddScoped<ICargoRepository, CargoRepository>();

            services.AddScoped<IColaboradorRepository, ColaboradorRepository>();

            return services;
        }
    }
}
