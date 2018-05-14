using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Corxx.Infra.IoC;
using Microsoft.Extensions.Configuration;
using System;

namespace Corxx.Api
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var config = AddConfiguration(services);
            var mvc = AddMvc(services);

            services.AddRepository(config.GetConnectionString("corxx"));

            services.AddMediatR();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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
            return services.AddMvc();
        }
    }
}
