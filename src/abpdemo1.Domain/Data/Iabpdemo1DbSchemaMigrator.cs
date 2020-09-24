using System.Threading.Tasks;

namespace abpdemo1.Data
{
    public interface Iabpdemo1DbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
