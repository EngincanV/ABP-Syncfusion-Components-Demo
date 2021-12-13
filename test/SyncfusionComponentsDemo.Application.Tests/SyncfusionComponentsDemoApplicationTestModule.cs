using Volo.Abp.Modularity;

namespace SyncfusionComponentsDemo
{
    [DependsOn(
        typeof(SyncfusionComponentsDemoApplicationModule),
        typeof(SyncfusionComponentsDemoDomainTestModule)
        )]
    public class SyncfusionComponentsDemoApplicationTestModule : AbpModule
    {

    }
}