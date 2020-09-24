using abpdemo1.Books;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace abpdemo1.EntityFrameworkCore
{
    public static class abpdemo1DbContextModelCreatingExtensions
    {
        public static void Configureabpdemo1(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            builder.Entity<Book>(b =>
            {
                b.ToTable(abpdemo1Consts.DbTablePrefix + "Books",
                          abpdemo1Consts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Name).IsRequired().HasMaxLength(128);
            });
        }
    }
}