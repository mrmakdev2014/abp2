using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace abpdemo1.EntityFrameworkCore
{
    [DependsOn(
        typeof(abpdemo1EntityFrameworkCoreModule)
        )]
    public class abpdemo1EntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<abpdemo1MigrationsDbContext>();
        }
    }
}
