using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Africell.Product.Products.Services
{
    public interface IServiceAppService : IApplicationService
    {
        public Task<ServiceDto> GetAsync(Guid id);

        public Task<PagedResultDto<ServiceDto>> GetListAsync(GetProductListDto input);

        public Task<ServiceDto> CreateAsync(CreateProductDto input);

        public Task<ServiceDto> UpdateAsync(Guid id, CreateServiceDto input);

        public Task DeleteAsync(Guid id);

    }
}
