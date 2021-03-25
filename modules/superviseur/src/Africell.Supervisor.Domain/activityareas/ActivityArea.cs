using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Africell.Supervisor.activityareas
{
    public class ActivityArea : FullAuditedAggregateRoot<Guid>
    {
        public  virtual Guid SupervisorId { get; set; }
        public virtual Guid placeId { get; set; }
        [ForeignKey("SupervisorId")]
        public supervisors.Supervisor Supervisor { get; set; }
    }
}
