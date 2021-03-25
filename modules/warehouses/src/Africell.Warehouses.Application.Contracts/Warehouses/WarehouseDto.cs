using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Africell.Warehouses.Warehouses
{
    public class WarehouseDto : FullAuditedEntityDto<Guid>
    {
        public virtual string RegionId { get; set; }
        public virtual string RegionName { get; set; }
    }
}
