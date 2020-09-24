using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace abpdemo1.Web
{
    [Dependency(ReplaceServices = true)]
    public class abpdemo1BrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "abpdemo1";
    }
}
