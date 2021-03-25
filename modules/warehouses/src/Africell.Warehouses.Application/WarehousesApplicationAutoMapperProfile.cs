using Africell.Warehouses.Warehouses;
using AutoMapper;

namespace Africell.Warehouses
{
    public class WarehousesApplicationAutoMapperProfile : Profile
    {
        public WarehousesApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Warehouse, WarehouseDto>();
            CreateMap<CreateUpdateWarehouseDto, Warehouse>();
        }
    }
}