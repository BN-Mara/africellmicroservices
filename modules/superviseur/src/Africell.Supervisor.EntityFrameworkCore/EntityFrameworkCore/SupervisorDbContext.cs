using Africell.Supervisor.activityareas;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Africell.Supervisor.EntityFrameworkCore
{
    [ConnectionStringName(SupervisorDbProperties.ConnectionStringName)]
    public class SupervisorDbContext : AbpDbContext<SupervisorDbContext>, ISupervisorDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */
        public DbSet<supervisors.Supervisor> Supervisors { get; set; }
        public DbSet<ActivityArea> ActivityAreas { get; set; }

        public SupervisorDbContext(DbContextOptions<SupervisorDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureSupervisor();
        }
    }
}