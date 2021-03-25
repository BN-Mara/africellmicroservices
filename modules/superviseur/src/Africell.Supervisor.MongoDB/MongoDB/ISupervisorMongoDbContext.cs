using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Africell.Supervisor.MongoDB
{
    [ConnectionStringName(SupervisorDbProperties.ConnectionStringName)]
    public interface ISupervisorMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
