using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Africell.Erp.Survey.EntityFrameworkCore
{
    [ConnectionStringName(SurveyDbProperties.ConnectionStringName)]
    public class SurveyDbContext : AbpDbContext<SurveyDbContext>, ISurveyDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public SurveyDbContext(DbContextOptions<SurveyDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureSurvey();
        }
    }
}