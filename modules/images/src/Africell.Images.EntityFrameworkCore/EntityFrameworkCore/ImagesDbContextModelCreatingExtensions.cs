using System;
using Africell.Images.Images;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Africell.Images.EntityFrameworkCore
{
    public static class ImagesDbContextModelCreatingExtensions
    {
        public static void ConfigureImages(
            this ModelBuilder builder,
            Action<ImagesModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new ImagesModelBuilderConfigurationOptions(
                ImagesDbProperties.DbTablePrefix,
                ImagesDbProperties.DbSchema
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
            builder.Entity<Image>(b =>
            {
                b.ToTable(options.TablePrefix + "Images", options.Schema);
                b.ConfigureByConvention();
                b.Property(x => x.Photo).IsRequired();
            });
        }
    }
}