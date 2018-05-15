using Corxx.Domain.Repositories;
using Corxx.Infra.Data;
using Corxx.Infra.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Corxx.Infra.IoC
{
    public static class RegisterInfraDependencies
    {
        public static void AddRepository(this IServiceCollection services, string connectionStrings)
        {
            services.AddDbContext<CorxxDataContext>(options =>
            {
                options.UseSqlServer(connectionStrings);
            });

            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddTransient<IUserRepository, UserRepository>();
        }
    }
}
