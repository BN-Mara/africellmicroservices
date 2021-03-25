using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Africell.Supervisor.supervisors
{
    public class SupervisorAppService : CrudAppService<Supervisor,SupervisorDto,Guid,
        PagedAndSortedResultRequestDto,CreateUpdateSupervisorDto>, ISupervisorAppService
    {
        public SupervisorAppService(IRepository<Supervisor,Guid> repository):base(repository)
        {


        }
    }
}
