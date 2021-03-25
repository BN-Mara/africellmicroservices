using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Africell.Warehouses.Warehouses
{
    public class WarehouseAppService : CrudAppService<Warehouse,WarehouseDto,Guid,PagedAndSortedResultRequestDto,CreateUpdateWarehouseDto>,IWarehouseAppService
    {
        public WarehouseAppService(IRepository<Warehouse, Guid> repository) : base(repository)
        {

        }
    }
}
