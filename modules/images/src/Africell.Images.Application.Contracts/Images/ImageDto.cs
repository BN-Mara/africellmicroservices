using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Africell.Images.Images
{
    public class ImageDto : FullAuditedEntityDto<Guid>
    {
        public virtual byte[] Photo { get; set; }
        public virtual string Description { get; set; }
    }
}
