using abpdemo1.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace abpdemo1.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class abpdemo1Controller : AbpController
    {
        protected abpdemo1Controller()
        {
            LocalizationResource = typeof(abpdemo1Resource);
        }
    }
}