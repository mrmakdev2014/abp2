using abpdemo1.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace abpdemo1.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(abpdemo1EntityFrameworkCoreDbMigrationsModule),
        typeof(abpdemo1ApplicationContractsModule)
        )]
    public class abpdemo1DbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
