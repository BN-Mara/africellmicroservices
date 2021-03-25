using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Africell.Supervisor.activityareas
{
    public class ActivityAreaDto : AuditedEntityDto<Guid>
    {
        public Guid SupervisorId { get; set; }
        public Guid PlaceId { get; set; }
    }
}
