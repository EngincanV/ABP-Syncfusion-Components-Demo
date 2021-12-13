using SyncfusionComponentsDemo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace SyncfusionComponentsDemo
{
    [DependsOn(
        typeof(SyncfusionComponentsDemoEntityFrameworkCoreTestModule)
        )]
    public class SyncfusionComponentsDemoDomainTestModule : AbpModule
    {

    }
}