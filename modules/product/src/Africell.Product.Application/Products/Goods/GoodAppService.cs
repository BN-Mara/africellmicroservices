using System;
using System.Collections.Generic;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Africell.Product.Products.Goods
{
    public class GoodAppService : ProductAppService, IGoodAppService
    {
        private IRepository<Good, Guid> _goodRepository;
        private ProductManager _productManager;

        public GoodAppService():base()
        {

        }
        public GoodAppService(IRepository<Good,Guid> goodRepository, ProductManager productManager):base()
        {
            _goodRepository = goodRepository;
            _productManager = productManager;
        }

        public async Task<GoodDto> CreateAsync(CreateGoodDto input)
        {
            var good = await _goodRepository.InsertAsync(
                new Good(
                    GuidGenerator.Create(),
                    input.Code,
                    input.Name,
                    input.Type,
                    input.Category,
                    input.Description,
                    input.LiveMode,
                    input.Metadata.ToString(),
                    input.Shippable,
                    input.UnitLabel,
                    input.ProductImage

                    )
                );

            return ObjectMapper.Map<Good, GoodDto>(good);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _goodRepository.DeleteAsync(id);
        }

        public async Task<GoodDto> GetAsync(Guid id)
        {
            var good = await _goodRepository.GetAsync(id);
           

            return ObjectMapper.Map<Good, GoodDto>(good);
        }

        public async Task<PagedResultDto<GoodDto>> GetListAsync(GetGoodListDto input)
        {
            var goods = await _goodRepository
                
               .OrderBy(input.Sorting ?? nameof(Good.Name))
               .Skip(input.SkipCount)
               .Take(input.MaxResultCount)
               .ToListAsync();
            var totalCount = await _goodRepository.GetCountAsync();

            var dtos = ObjectMapper.Map<List<Good>, List<GoodDto>>(goods);

            return new PagedResultDto<GoodDto>(totalCount, dtos);
        }

        public async Task<GoodDto> UpdateAsync(Guid id, CreateGoodDto input)
        {
            var good = await _goodRepository.GetAsync(id);
            //service.Code = input.Code;
            good.SetName(input.Name);
            good.SetType(input.Type);
            good.SetCategory(input.Category);
            good.SetDescription(input.Description);
            good.SetLiveMode(input.LiveMode);
            good.SetMetaData(input.Metadata.ToString());
            good.SetProductImage(input.ProductImage);
            good.SetShippable(input.Shippable);
            good.SetUnitLabel(input.UnitLabel);

            return ObjectMapper.Map<Good, GoodDto>(good);
        }
        /*public Task<GoodDto> GetAsync()
        {
            return Task.FromResult(
                new GoodDto
                {
                   
                }
            );
        }*/
    }
}
