using ApplicationCore.Interfaces.Repository;
using ApplicationCore.Interfaces.UnitOfWork;
using Infrastructure.Repositories;
using Infrastructure.UOW;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class InfraServiceRegistration
    {
        public static void AddInfraServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IAsyncGenericRepository<>), typeof(GenericRepository<>));
            serviceCollection.AddScoped<IUserRepository, UserRepository>();
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
        }


    }
}
