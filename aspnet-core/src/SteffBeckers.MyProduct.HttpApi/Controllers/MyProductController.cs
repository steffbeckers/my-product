using SteffBeckers.MyProduct.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SteffBeckers.MyProduct.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MyProductController : AbpControllerBase
{
    protected MyProductController()
    {
        LocalizationResource = typeof(MyProductResource);
    }
}
