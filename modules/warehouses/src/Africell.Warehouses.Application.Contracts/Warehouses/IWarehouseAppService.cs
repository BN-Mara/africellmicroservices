using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Africell.Warehouses.Warehouses
{
    public interface IWarehouseAppService : ICrudAppService<WarehouseDto,Guid,PagedAndSortedResultRequestDto,CreateUpdateWarehouseDto>
    {
    }
}
