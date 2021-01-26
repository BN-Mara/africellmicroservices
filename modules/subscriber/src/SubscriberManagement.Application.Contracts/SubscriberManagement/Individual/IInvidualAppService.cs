using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SubscriberManagement
{
    public interface IIndividualAppService : ICrudAppService<SubscriberDto, Guid, IndividualGetListInput, IndividualInput>,ISubscriberAppService
    {
        Task<ListResultDto<SubscriberDto>> GetListAsync();
        
    }
}
