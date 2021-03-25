using Africell.Product.Products.Goods;
using Africell.Product.Products.Services;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Africell.Product.EntityFrameworkCore
{
    [ConnectionStringName(ProductDbProperties.ConnectionStringName)]
    public interface IProductDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
        public DbSet<Products.Product> Products { get; }
        public DbSet<Good> Goods { get; }
        public DbSet<Service> Services { get; }
    }
}