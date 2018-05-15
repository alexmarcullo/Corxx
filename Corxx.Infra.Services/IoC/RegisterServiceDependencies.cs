using Corxx.Domain.Services;
using Corxx.Infra.Services.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Corxx.Infra.Services.IoC
{
    public static class RegisterServiceDependencies
    {
        public static void AddServices(this IServiceCollection services, string hostName, int port, string credentialsUsername, string credentialsPassword, bool enableSsl = false)
        {
            services.AddScoped<IEmailService>(x => new EmailService(hostName, port, credentialsUsername, credentialsPassword, enableSsl));
        }
    }
}
