using System;
using System.Collections.Generic;
using System.Text;
using SteffBeckers.MyProduct.Localization;
using Volo.Abp.Application.Services;

namespace SteffBeckers.MyProduct;

/* Inherit your application services from this class.
 */
public abstract class MyProductAppService : ApplicationService
{
    protected MyProductAppService()
    {
        LocalizationResource = typeof(MyProductResource);
    }
}
