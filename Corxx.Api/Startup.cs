using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Corxx.Infra.IoC;
using Corxx.Domain.Commands.IoC;
using Microsoft.Extensions.Configuration;
using System;
using Microsoft.AspNetCore.Mvc.Formatters;
using Corxx.Infra.Services.IoC;

namespace Corxx.Api
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            var config = AddConfiguration(services);
            var mvc = AddMvc(services);

            services.AddCors();

            services.AddRepository(config.GetConnectionString("corxx"));
            services.AddHandlers();
            services.AddServices(config["emailService:hostname"], int.Parse(config["emailService:port"]), config["emailService:username"], config["emailService:password"], bool.Parse(config["emailService:enableSsl"]));

            services.AddMediatR();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }

        private static IConfigurationRoot AddConfiguration(IServiceCollection services)
        {
            var config = new ConfigurationBuilder()
                            .SetBasePath(AppContext.BaseDirectory)
                            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                            .AddEnvironmentVariables()
                            .Build();

            services.AddSingleton<IConfigurationRoot>(config);
            services.AddOptions();
            return config;
        }

        private static IMvcBuilder AddMvc(IServiceCollection services)
        {
            return services
                .AddMvc(options =>
                {
                    options.InputFormatters.Add(new XmlSerializerInputFormatter());
                    options.OutputFormatters.Add(new XmlSerializerOutputFormatter());
                })
                .AddXmlSerializerFormatters();
        }
    }
}
