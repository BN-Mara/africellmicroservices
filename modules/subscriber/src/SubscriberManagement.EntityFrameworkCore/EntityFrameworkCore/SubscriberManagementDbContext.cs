using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace SubscriberManagement.EntityFrameworkCore
{
    [ConnectionStringName(SubscriberManagementDbProperties.ConnectionStringName)]
    public class SubscriberManagementDbContext : AbpDbContext<SubscriberManagementDbContext>, ISubscriberManagementDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */
        public DbSet<Individual> Individuals { get; set; }
        public DbSet<Entreprise> Entreprises { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }
        public SubscriberManagementDbContext(DbContextOptions<SubscriberManagementDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureSubscriberManagement();
        }
    }
}