using SteffBeckers.MyProduct.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace SteffBeckers.MyProduct;

[DependsOn(
    typeof(MyProductEntityFrameworkCoreTestModule)
    )]
public class MyProductDomainTestModule : AbpModule
{

}
