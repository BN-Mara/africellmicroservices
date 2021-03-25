using Africell.Supervisor.activityareas;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Africell.Supervisor.EntityFrameworkCore
{
    [ConnectionStringName(SupervisorDbProperties.ConnectionStringName)]
    public interface ISupervisorDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
        DbSet<supervisors.Supervisor> Supervisors { get; }
        public DbSet<ActivityArea> ActivityAreas { get; set; }
    }
}