using abpdemo1.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace abpdemo1.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class abpdemo1PageModel : AbpPageModel
    {
        protected abpdemo1PageModel()
        {
            LocalizationResourceType = typeof(abpdemo1Resource);
        }
    }
}