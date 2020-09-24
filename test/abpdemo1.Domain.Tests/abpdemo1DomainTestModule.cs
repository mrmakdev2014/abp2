using abpdemo1.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace abpdemo1
{
    [DependsOn(
        typeof(abpdemo1EntityFrameworkCoreTestModule)
        )]
    public class abpdemo1DomainTestModule : AbpModule
    {

    }
}