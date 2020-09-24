using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace abpdemo1
{
    public class abpdemo1WebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<abpdemo1WebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}