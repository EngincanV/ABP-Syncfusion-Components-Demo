using SyncfusionComponentsDemo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace SyncfusionComponentsDemo.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(SyncfusionComponentsDemoEntityFrameworkCoreModule),
        typeof(SyncfusionComponentsDemoApplicationContractsModule)
        )]
    public class SyncfusionComponentsDemoDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
