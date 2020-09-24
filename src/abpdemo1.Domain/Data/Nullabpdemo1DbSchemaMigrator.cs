using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace abpdemo1.Data
{
    /* This is used if database provider does't define
     * Iabpdemo1DbSchemaMigrator implementation.
     */
    public class Nullabpdemo1DbSchemaMigrator : Iabpdemo1DbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}