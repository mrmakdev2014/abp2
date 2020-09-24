using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace abpdemo1.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<abpdemo1WebModule>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.InitializeApplication();
        }
    }
}
