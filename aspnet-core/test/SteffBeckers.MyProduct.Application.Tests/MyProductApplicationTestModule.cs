using Volo.Abp.Modularity;

namespace SteffBeckers.MyProduct;

[DependsOn(
    typeof(MyProductApplicationModule),
    typeof(MyProductDomainTestModule)
    )]
public class MyProductApplicationTestModule : AbpModule
{

}
