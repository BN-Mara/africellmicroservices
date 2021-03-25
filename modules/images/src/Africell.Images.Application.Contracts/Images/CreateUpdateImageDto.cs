using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Africell.Images.Images
{
    public class CreateUpdateImageDto
    {
        [Required]
        public virtual byte[] Photo { get; set; }
        public virtual string Description { get; set; }

    }
}
