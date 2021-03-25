using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Africell.Supervisor.activityareas
{
    public interface IActivityAreaAppService : ICrudAppService<
        ActivityAreaDto,Guid,PagedAndSortedResultRequestDto,CreateUpdateActivityArea>
    {
    }
}
