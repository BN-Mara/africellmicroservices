using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Africell.Supervisor.supervisors
{
    public interface ISupervisorAppService : ICrudAppService<SupervisorDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateSupervisorDto>
    {
    }
}
