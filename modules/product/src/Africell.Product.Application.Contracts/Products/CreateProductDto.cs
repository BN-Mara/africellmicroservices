using Africell.Products;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Africell.Product.Products
{
    public class CreateProductDto
    {
        [Required]
        [StringLength(ProductConsts.MaxCodeLength)]
        public virtual string Code { get; set; }
        [Required]
        [StringLength(ProductConsts.MaxNameLength)]
        public virtual string Name { get; set; }
        public virtual byte[] ProductImage { get; set; }

        [Required]
        public virtual ProductType Type { get; set; }
        public virtual ProductCategory Category { get; set; }
        public virtual string Description { get; set; }
        public virtual bool LiveMode { get; set; }
        public virtual string Metadata { get; set; }
    }
}
