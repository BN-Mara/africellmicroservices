using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Africell.Product.Products
{
    public interface IProductAppService : IApplicationService
    {
        Task<ProductDto> GetAsync(Guid id);

        Task<PagedResultDto<ProductDto>> GetListAsync(GetProductListDto input);

        Task<ProductDto> CreateAsync(CreateProductDto input);

        Task UpdateAsync(Guid id, CreateProductDto input);

        Task DeleteAsync(Guid id);
    }
}
