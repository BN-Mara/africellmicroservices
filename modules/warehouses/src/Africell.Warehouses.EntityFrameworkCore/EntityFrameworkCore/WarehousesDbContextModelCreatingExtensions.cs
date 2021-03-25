using System;
using Africell.Warehouses.Warehouses;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Africell.Warehouses.EntityFrameworkCore
{
    public static class WarehousesDbContextModelCreatingExtensions
    {
        public static void ConfigureWarehouses(
            this ModelBuilder builder,
            Action<WarehousesModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new WarehousesModelBuilderConfigurationOptions(
                WarehousesDbProperties.DbTablePrefix,
                WarehousesDbProperties.DbSchema
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
            builder.Entity<Warehouse>(b =>
            {
                b.ToTable(options.TablePrefix + "Warehouses", options.Schema);
                b.ConfigureByConvention();
                b.Property(x => x.RegionId).IsRequired();
                b.Property(x => x.RegionName).HasMaxLength(64);

            });
        }
    }
}