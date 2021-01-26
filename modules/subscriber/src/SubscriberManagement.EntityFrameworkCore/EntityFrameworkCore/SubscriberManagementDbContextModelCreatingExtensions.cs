using System;
using Africell.Erp.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace SubscriberManagement.EntityFrameworkCore
{
    public static class SubscriberManagementDbContextModelCreatingExtensions
    {
        public static void ConfigureSubscriberManagement(
            this ModelBuilder builder,
            Action<SubscriberManagementModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new SubscriberManagementModelBuilderConfigurationOptions(
                SubscriberManagementDbProperties.DbTablePrefix,
                SubscriberManagementDbProperties.DbSchema
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
            builder.Entity<Subscriber>(b => {
                b.ToTable(options.TablePrefix + "Subscribers", options.Schema);
                b.ConfigureByConvention();
            });
          
            var converter = new ValueConverter<IDType, string>(
                                    v => v.ToString(),
                                    v => (IDType)Enum.Parse(typeof(IDType), v));
            var converter1 = new ValueConverter<Gender, string>(
                                   v => v.ToString(),
                                   v => (Gender)Enum.Parse(typeof(Gender), v));
            builder.Entity<Individual>(b => {
                b.Property(c => c.IDType).HasConversion(converter);
                b.Property(c => c.Gender).HasConversion(converter1).HasMaxLength(1);
            });
            builder.Entity<Subscriber>()
               .HasDiscriminator(b => b.Type)
               .HasValue<Individual>(SubscriberType.INDIVIDUAL)
               .HasValue<Entreprise>(SubscriberType.ENTREPRISE);
        }
    }
}