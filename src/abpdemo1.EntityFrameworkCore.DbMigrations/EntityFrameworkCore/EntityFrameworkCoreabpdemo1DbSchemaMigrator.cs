using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using abpdemo1.Data;
using Volo.Abp.DependencyInjection;

namespace abpdemo1.EntityFrameworkCore
{
    public class EntityFrameworkCoreabpdemo1DbSchemaMigrator
        : Iabpdemo1DbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreabpdemo1DbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the abpdemo1MigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<abpdemo1MigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}