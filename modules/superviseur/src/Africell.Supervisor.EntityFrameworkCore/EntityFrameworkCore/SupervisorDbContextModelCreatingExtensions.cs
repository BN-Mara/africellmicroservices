using System;
using Africell.Supervisor.activityareas;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Africell.Supervisor.EntityFrameworkCore
{
    public static class SupervisorDbContextModelCreatingExtensions
    {
        public static void ConfigureSupervisor(
            this ModelBuilder builder,
            Action<SupervisorModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new SupervisorModelBuilderConfigurationOptions(
                SupervisorDbProperties.DbTablePrefix,
                SupervisorDbProperties.DbSchema
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
            builder.Entity<supervisors.Supervisor>(b =>
            {
                b.ToTable(options.TablePrefix + "Supervisors", options.Schema);
                b.ConfigureByConvention();
                b.Property(x => x.Name).HasMaxLength(128).IsRequired();
            }
            );
            builder.Entity<ActivityArea>(b =>
            {
                b.ToTable(options.TablePrefix + "ActivityAreas", options.Schema);
                b.ConfigureByConvention();
                b.Property(x => x.SupervisorId).IsRequired();
            });

            
        }
    }
}