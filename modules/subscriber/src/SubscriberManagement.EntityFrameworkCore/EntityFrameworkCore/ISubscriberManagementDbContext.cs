using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace SubscriberManagement.EntityFrameworkCore
{
    [ConnectionStringName(SubscriberManagementDbProperties.ConnectionStringName)]
    public interface ISubscriberManagementDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}