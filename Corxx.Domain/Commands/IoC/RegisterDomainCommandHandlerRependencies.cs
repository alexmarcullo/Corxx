using Corxx.Domain.Commands.Handlers;
using Microsoft.Extensions.DependencyInjection;

namespace Corxx.Domain.Commands.IoC
{
    public static class RegisterDomainCommandHandlerRependencies
    {
        public static void AddHandlers(this IServiceCollection services)
        {
            services.AddTransient<UserCommandHandler, UserCommandHandler>();
        }
    }
}
