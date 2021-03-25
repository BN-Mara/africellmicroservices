using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Africell.Warehouses.Warehouses
{
    public class Warehouse : FullAuditedAggregateRoot<Guid>
    {
        public virtual Guid RegionId { get; set; }
        public virtual string RegionName { get; set; }
       
    }
}
