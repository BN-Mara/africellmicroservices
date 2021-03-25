using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc;

namespace Africell.Warehouses.Warehouses
{
    [RemoteService]
    [Route("api/Warehouses/")]
    /*public*/ class WarehouseController : AbpController, IWarehouseAppService
    {
        private readonly IWarehouseAppService _warehouseAppService;
        public WarehouseController(IWarehouseAppService warehouseAppService)
        {
            _warehouseAppService = warehouseAppService;
        }

        [HttpPost]
        [Route("warehouse")]
        public async Task<WarehouseDto> CreateAsync(CreateUpdateWarehouseDto input)
        {
            return await _warehouseAppService.CreateAsync(input);
        }

        [HttpDelete]
        [Route("warehouse")]
        public Task DeleteAsync(Guid id)
        {
            return _warehouseAppService.DeleteAsync(id);
        }

        [HttpGet]
        [Route("warehouse/{id}")]
        public async Task<WarehouseDto> GetAsync(Guid id)
        {
            return await _warehouseAppService.GetAsync(id);
        }


        [HttpGet]
        [Route("warehouse")]
        public async Task<PagedResultDto<WarehouseDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            return await _warehouseAppService.GetListAsync(input);
        }

        [HttpPut]
        [Route("warehouse/{id}")]
        public async Task<WarehouseDto> UpdateAsync(Guid id, CreateUpdateWarehouseDto input)
        {
            return await _warehouseAppService.UpdateAsync(id,input);
        }

    }
}
