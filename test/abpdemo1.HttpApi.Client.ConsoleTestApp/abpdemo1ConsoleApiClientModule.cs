using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace abpdemo1.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(abpdemo1HttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class abpdemo1ConsoleApiClientModule : AbpModule
    {
        
    }
}
