using SteffBeckers.MyProduct.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace SteffBeckers.MyProduct.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MyProductEntityFrameworkCoreModule),
    typeof(MyProductApplicationContractsModule)
    )]
public class MyProductDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
