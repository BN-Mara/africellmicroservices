using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SubscriberManagement.Authorization;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace SubscriberManagement
{
    [RemoteService]
    [Area("subscriberManagement")]
    [Route("api/subscriberManagement/individuals")]
    public class IndividualController: SubscriberManagementController
    {
        private readonly IIndividualAppService appService;
        public IndividualController(IIndividualAppService individualAppService)
        {
            appService = individualAppService;
        }
        [HttpPost]
        public Task<SubscriberDto> CreateAsync(IndividualInput input)
       {
            return appService.CreateAsync(input);
       }
        [HttpPut]
        [Route("{id}")]
        public Task<SubscriberDto> UpdateAsync(Guid id, IndividualInput input)
       {
            return appService.UpdateAsync(id, input);
       }
        [HttpPut]
        [Route("verify/{id}")]
        public Task<SubscriberDto> VerifyAsync(Guid id, bool IsValid)
        {
            return appService.Check(id, IsValid);
        }
        [HttpGet]
        [Route("")]
        public async Task<PagedResultDto<SubscriberDto>> GetListAsync(IndividualGetListInput input)
        {
            return await appService.GetListAsync(input);
        }

        [HttpGet]
        [Route("all")]
        [Authorize(SubscriberManagementPermissions.Individuals.ViewAll)]
        public Task<ListResultDto<SubscriberDto>> GetListAsync()
        {
            return appService.GetListAsync();
        }
        [HttpGet]
        [Route("{id}")]
        public Task<SubscriberDto> GetAsync(Guid id)
        {
            return appService.GetAsync(id);
        }
    }
}
