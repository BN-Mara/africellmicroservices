using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Africell.Erp.Survey.EntityFrameworkCore
{
    public class SurveyHttpApiHostMigrationsDbContext : AbpDbContext<SurveyHttpApiHostMigrationsDbContext>
    {
        public SurveyHttpApiHostMigrationsDbContext(DbContextOptions<SurveyHttpApiHostMigrationsDbContext> options)
            : base(options)
        {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureSurvey();
        }
    }
}
