using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Africell.Warehouses.Warehouses
{
    public class CreateUpdateWarehouseDto 
    {
        [Required]
        public virtual Guid RegionId { get; set; }

        public virtual string RegionName { get; set; }
        
    }
}
