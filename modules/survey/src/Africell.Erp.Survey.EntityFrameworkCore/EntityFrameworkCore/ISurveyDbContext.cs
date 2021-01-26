using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Africell.Erp.Survey.EntityFrameworkCore
{
    [ConnectionStringName(SurveyDbProperties.ConnectionStringName)]
    public interface ISurveyDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}