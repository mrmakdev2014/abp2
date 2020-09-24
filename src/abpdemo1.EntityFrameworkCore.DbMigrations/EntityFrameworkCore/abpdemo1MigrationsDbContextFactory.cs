using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace abpdemo1.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class abpdemo1MigrationsDbContextFactory : IDesignTimeDbContextFactory<abpdemo1MigrationsDbContext>
    {
        public abpdemo1MigrationsDbContext CreateDbContext(string[] args)
        {
            abpdemo1EfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<abpdemo1MigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new abpdemo1MigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../abpdemo1.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
