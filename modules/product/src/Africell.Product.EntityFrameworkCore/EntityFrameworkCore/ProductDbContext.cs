using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Africell.Product.Products.Goods;
using Africell.Product.Products.Services;

namespace Africell.Product.EntityFrameworkCore
{
    [ConnectionStringName(ProductDbProperties.ConnectionStringName)]
    public class ProductDbContext : AbpDbContext<ProductDbContext>, IProductDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */
        public DbSet<Products.Product> Products { get; set; }
        public DbSet<Good> Goods { get; set; }
        public DbSet<Service> Services { get; set; }
       

        public ProductDbContext(DbContextOptions<ProductDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureProduct();
        }
    }
}