using Volo.Abp.Modularity;

namespace abpdemo1
{
    [DependsOn(
        typeof(abpdemo1ApplicationModule),
        typeof(abpdemo1DomainTestModule)
        )]
    public class abpdemo1ApplicationTestModule : AbpModule
    {

    }
}