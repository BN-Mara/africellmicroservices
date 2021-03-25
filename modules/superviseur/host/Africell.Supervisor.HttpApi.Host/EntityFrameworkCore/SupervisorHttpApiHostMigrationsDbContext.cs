using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Africell.Supervisor.EntityFrameworkCore
{
    public class SupervisorHttpApiHostMigrationsDbContext : AbpDbContext<SupervisorHttpApiHostMigrationsDbContext>
    {
        public SupervisorHttpApiHostMigrationsDbContext(DbContextOptions<SupervisorHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureSupervisor();
        }
    }
}
