using System;
using System.Collections.Generic;
using System.Text;
using abpdemo1.Localization;
using Volo.Abp.Application.Services;

namespace abpdemo1
{
    /* Inherit your application services from this class.
     */
    public abstract class abpdemo1AppService : ApplicationService
    {
        protected abpdemo1AppService()
        {
            LocalizationResource = typeof(abpdemo1Resource);
        }
    }
}
