using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Africell.Product.Products
{
    public class GetProductListDto :  PagedAndSortedResultRequestDto
    {
        public string Filter { get;set; }
        public ProductType Type { get; set; }

    }
}
