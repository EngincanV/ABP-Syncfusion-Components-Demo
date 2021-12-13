using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace SyncfusionComponentsDemo.Data
{
    /* This is used if database provider does't define
     * ISyncfusionComponentsDemoDbSchemaMigrator implementation.
     */
    public class NullSyncfusionComponentsDemoDbSchemaMigrator : ISyncfusionComponentsDemoDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}