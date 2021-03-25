using Africell.Supervisor.activityareas;
using Africell.Supervisor.supervisors;
using AutoMapper;

namespace Africell.Supervisor
{
    public class SupervisorApplicationAutoMapperProfile : Profile
    {
        public SupervisorApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<supervisors.Supervisor, SupervisorDto>();

            CreateMap<CreateUpdateSupervisorDto, supervisors.Supervisor>();
            CreateMap<ActivityArea, ActivityAreaDto>();
            CreateMap<CreateUpdateActivityArea, ActivityArea>();
        }
    }
}