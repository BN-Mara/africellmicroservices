using Africell.Supervisor.activityareas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Africell.Supervisor.supervisors
{
    public class Supervisor : FullAuditedAggregateRoot<Guid>
    {
        public virtual byte[] Photo { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime BirthDate { get; set; }
        public virtual string Address { get; set; }
        public virtual string City { get; set; }

        [InverseProperty("Supervisor")]
        public virtual IList<ActivityArea> ActivityAreas { get; set; }

        //public Supervisor()

    }
}
