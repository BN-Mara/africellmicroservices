using Africell.Product.Products.Services;
using Africell.Products;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Africell.Product.Products
{
    public class ServiceAppService_Tests : ProductApplicationTestBase
    {
        private readonly IServiceAppService _serviceAppService;

        public ServiceAppService_Tests()
        {
            _serviceAppService = GetRequiredService<IServiceAppService>();

        }
        [Fact]
        public async Task Should_Get_All_Services_without_Filter()
        {
            var result = await _serviceAppService.GetListAsync(new GetServiceListDto());
            
        }
        [Fact]
        public async Task Should_Create_New_Product()
        {
            
          

            var serviceDto = await _serviceAppService.CreateAsync(
                new CreateProductDto
                {

                    Code = "Code12389",
                    Name = "Product 5",
                    ProductImage = null,
                    Type = ProductType.Devices,
                    Category = ProductCategory.Service,
                    Description = "short description",
                    LiveMode = true,
                    Metadata = "color:white"
                }
                );
            serviceDto.Id.ShouldNotBe(Guid.Empty);
            serviceDto.Name.ShouldBe("Product 5");
        }

    }
}
