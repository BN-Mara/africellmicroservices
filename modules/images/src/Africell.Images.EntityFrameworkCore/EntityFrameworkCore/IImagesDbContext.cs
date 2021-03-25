using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Africell.Images.EntityFrameworkCore
{
    [ConnectionStringName(ImagesDbProperties.ConnectionStringName)]
    public interface IImagesDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}