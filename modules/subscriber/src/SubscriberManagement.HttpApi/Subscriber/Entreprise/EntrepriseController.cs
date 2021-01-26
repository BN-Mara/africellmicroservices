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
    [Route("api/subscriberManagement/entreprises")]
    public class EntrepriseController :SubscriberManagementController
    {
        private readonly IEntrepriseAppService appService;
        public EntrepriseController(IEntrepriseAppService entrepriseAppService)
        {
            appService = entrepriseAppService;
        }
        [HttpPost]
        public Task<SubscriberDto> CreateAsync(EntrepriseInput input)
        {
            return appService.CreateAsync(input);
        }
        [HttpPut]
        [Route("{id}")]
        public Task<SubscriberDto> UpdateAsync(Guid id, EntrepriseInput input)
        {
            return appService.UpdateAsync(id, input);
        }
        [HttpGet]
        [Route("")]
        public Task<PagedResultDto<SubscriberDto>> GetListAsync(EntrepriseGetListInput input)
        {
            return appService.GetListAsync(input);
        }
        [HttpPut]
        [Route("verify/{id}")]
        public Task<SubscriberDto> VerifyAsync(Guid id, bool IsValid)
        {
            return appService.Check(id, IsValid);
        }
        [HttpGet]
        [Route("all")]
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
