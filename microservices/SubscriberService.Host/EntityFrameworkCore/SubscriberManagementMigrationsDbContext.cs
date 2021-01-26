using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;


namespace SubscriberManagement.EntityFrameworkCore
{
    /* This DbContext is only used for database migrations.
     * It is not used on runtime. See SubscriberManagementDbContext for the runtime DbContext.
     * It is a unified model that includes configuration for
     * all used modules and your application.
     */
    [ConnectionStringName(SubscriberManagementDbProperties.ConnectionStringName)]
    public class SubscriberManagementMigrationsDbContext : AbpDbContext<SubscriberManagementMigrationsDbContext>
    {
        public SubscriberManagementMigrationsDbContext(DbContextOptions<SubscriberManagementMigrationsDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Include modules to your migration db context */

            builder.ConfigureAuditLogging();
            /* Configure your own tables/entities inside the ConfigureSubscriberManagement method */

            builder.ConfigureSubscriberManagement();
        }
    }
}