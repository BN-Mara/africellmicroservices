using System;

using Africell.Product.Products;
using Africell.Product.Products.Goods;
using Africell.Product.Products.Services;
using Africell.Products;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Africell.Product.EntityFrameworkCore
{
    public static class ProductDbContextModelCreatingExtensions
    {
        public static void ConfigureProduct(
            this ModelBuilder builder,
            Action<ProductModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new ProductModelBuilderConfigurationOptions(
                ProductDbProperties.DbTablePrefix,
                ProductDbProperties.DbSchema
            );

            optionsAction?.Invoke(options);

            /* Configure all entities here. Example:

            builder.Entity<Question>(b =>
            {
                //Configure table & schema name
                b.ToTable(options.TablePrefix + "Questions", options.Schema);
            
                b.ConfigureByConvention();
            
                //Properties
                b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);
                
                //Relations
                b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

                //Indexes
                b.HasIndex(q => q.CreationTime);
            });
            */
            builder.Entity<Products.Product>(b =>
            {
                b.ToTable(options.TablePrefix + "Products", options.Schema);

                b.HasDiscriminator<ProductCategory>("Category")
                .HasValue<Products.Product>(ProductCategory.Undefined)
                .HasValue<Good>(ProductCategory.Goods)
                .HasValue<Service>(ProductCategory.Service);

                b.ConfigureByConvention();
                b.Property(x => x.Code).IsRequired().HasMaxLength(ProductConsts.MaxCodeLength);
                b.Property(x => x.Name).IsRequired().HasMaxLength(ProductConsts.MaxNameLength);
                b.HasIndex(q => q.Code);
                b.HasIndex(q => q.Name);

            });

            builder.Entity<Good>(b =>
            {
                b.ToTable(options.TablePrefix + "Products", options.Schema);
                b.ConfigureByConvention();

            });
            builder.Entity<Service>(b =>
            {
                b.ToTable(options.TablePrefix + "Products", options.Schema);
                b.ConfigureByConvention();

            });

        }
    }
}