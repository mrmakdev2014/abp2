using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace abpdemo1.EntityFrameworkCore
{
    public static class abpdemo1DbContextModelCreatingExtensions
    {
        public static void Configureabpdemo1(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(abpdemo1Consts.DbTablePrefix + "YourEntities", abpdemo1Consts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}