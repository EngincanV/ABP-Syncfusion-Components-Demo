using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace SyncfusionComponentsDemo.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class SyncfusionComponentsDemoDbContextFactory : IDesignTimeDbContextFactory<SyncfusionComponentsDemoDbContext>
    {
        public SyncfusionComponentsDemoDbContext CreateDbContext(string[] args)
        {
            SyncfusionComponentsDemoEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<SyncfusionComponentsDemoDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new SyncfusionComponentsDemoDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../SyncfusionComponentsDemo.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
