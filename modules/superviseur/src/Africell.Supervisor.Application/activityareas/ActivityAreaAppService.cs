using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Africell.Supervisor.activityareas
{
    public class ActivityAreaAppService : CrudAppService<ActivityArea,ActivityAreaDto,
        Guid,PagedAndSortedResultRequestDto,CreateUpdateActivityArea>, IActivityAreaAppService
    {
        public ActivityAreaAppService(IRepository<ActivityArea,Guid> repository):base(repository)
        {

        }
    }
}
