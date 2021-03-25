using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Africell.Product.Products.Goods
{
    public interface IGoodAppService : IApplicationService
    {
        public Task<GoodDto> GetAsync(Guid id);

        public Task<PagedResultDto<GoodDto>> GetListAsync(GetGoodListDto input);

        public Task<GoodDto> CreateAsync(CreateGoodDto input);

        public Task<GoodDto> UpdateAsync(Guid id, CreateGoodDto input);

        public Task DeleteAsync(Guid id);
    }
}
