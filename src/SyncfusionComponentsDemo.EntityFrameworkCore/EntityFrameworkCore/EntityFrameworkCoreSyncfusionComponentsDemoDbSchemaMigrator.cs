using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SyncfusionComponentsDemo.Data;
using Volo.Abp.DependencyInjection;

namespace SyncfusionComponentsDemo.EntityFrameworkCore
{
    public class EntityFrameworkCoreSyncfusionComponentsDemoDbSchemaMigrator
        : ISyncfusionComponentsDemoDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreSyncfusionComponentsDemoDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the SyncfusionComponentsDemoDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<SyncfusionComponentsDemoDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
