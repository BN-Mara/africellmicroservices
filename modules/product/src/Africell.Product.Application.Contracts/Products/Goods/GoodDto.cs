using System;
using System.Collections.Generic;
using System.Text;

namespace Africell.Product.Products.Goods
{
    public class GoodDto : ProductDto
    {
        public bool Shippable { get; set; }
        public string UnitLabel { get; set; }
    }
}
