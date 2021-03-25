using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Africell.Supervisor.MongoDB
{
    [ConnectionStringName(SupervisorDbProperties.ConnectionStringName)]
    public class SupervisorMongoDbContext : AbpMongoDbContext, ISupervisorMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureSupervisor();
        }
    }
}