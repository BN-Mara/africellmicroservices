using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Africell.Images.Images
{
   public class Image : FullAuditedAggregateRoot<Guid>
    {
        public byte[] Photo { get; set; }
        public virtual string Description { get; set; }


    }
}
