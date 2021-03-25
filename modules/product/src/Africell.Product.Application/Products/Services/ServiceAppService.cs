using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Services;
using System.Linq.Dynamic.Core;
using System.Linq;
using Africell.Product.Permissions;
using Microsoft.AspNetCore.Authorization;

namespace Africell.Product.Products.Services
{
    public class ServiceAppService : ProductAppService, IServiceAppService
    {
        private IRepository<Service, Guid> _serviceRepository;
        private ProductManager _serviceManager;

       
        public ServiceAppService(IRepository<Service, Guid> serviceRepository, ProductManager serviceManager)
        {
            _serviceManager = serviceManager;
            _serviceRepository = serviceRepository;
        }

        //[Authorize(ProductPermissions.Products.Create)]
        public async Task<ServiceDto> CreateAsync(CreateProductDto input)
        {
            var service = await _serviceRepository.InsertAsync(
                new Service(
                    GuidGenerator.Create(),
                    input.Code,
                    input.Name,
                    input.Type,
                    input.Category,
                    input.Description,
                    input.LiveMode,
                    input.Metadata,
                    input.ProductImage

                    )
                ) ;

            return ObjectMapper.Map<Service, ServiceDto>(service);
            
                
        }

        [Authorize(ProductPermissions.Products.Delete)]
        public async Task DeleteAsync(Guid id)
        {
            await _serviceRepository.DeleteAsync(id);
            
        }

        public async Task<ServiceDto> GetAsync(Guid id)
        {
            var service = await _serviceRepository.GetAsync(id);

            return ObjectMapper.Map<Service, ServiceDto>(service);
            
            
        }

        public async Task<PagedResultDto<ServiceDto>> GetListAsync(GetProductListDto input)
        {
            //await NormalizeMaxResultCountAsync(input);
            var services = await _serviceRepository
                /*.GetListAsync(
                input.SkipCount,
                input.MaxResultCount,
                input.Sorting,
                input.Filter

                );*/
                .OrderBy(input.Sorting ?? nameof(Service.Name))
                .Skip(input.SkipCount)
                .Take(input.MaxResultCount)
                .ToListAsync();
            var totalCount = await _serviceRepository.GetCountAsync();

            var dtos = ObjectMapper.Map<List<Service>, List<ServiceDto>>(services);

            return new PagedResultDto<ServiceDto>(totalCount, dtos);
        }

        [Authorize(ProductPermissions.Products.Edit)]
        public async Task<ServiceDto> UpdateAsync(Guid id, CreateServiceDto input)
        {
            var service = await _serviceRepository.GetAsync(id);
            //service.Code = input.Code;
            service.SetName(input.Name);
            service.SetType(input.Type);
            service.SetCategory(input.Category);
            service.SetDescription(input.Description);
            service.SetLiveMode(input.LiveMode);
            service.SetMetaData(input.Metadata.ToString());
            service.SetProductImage(input.ProductImage);
            
            return ObjectMapper.Map<Service, ServiceDto>(service);


        }

      
    }

}
