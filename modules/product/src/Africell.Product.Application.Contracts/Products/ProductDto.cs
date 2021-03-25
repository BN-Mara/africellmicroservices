using Africell.Products;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Africell.Product.Products
{
    public class ProductDto : FullAuditedEntityDto<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public byte[] ProductImage { get; set; }
        public ProductType Product { get; set; }
        public ProductCategory Category { get; set; }
        public string Description { get; set; }
        public bool LiveMode { get; set; }
        public string Metadata { get; set; }


    }
}
