using System.Threading.Tasks;
using Africell.Product.Products.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace Africell.Product.Samples
{
    [RemoteService]
    [Route("api/Product/sample")]
    public class SampleController : ProductController, ISampleAppService
    {
        private readonly ISampleAppService _sampleAppService;
        private readonly IServiceAppService _serviceAppService;

        public SampleController(ISampleAppService sampleAppService)
        {
            _sampleAppService = sampleAppService;
        }

        [HttpGet]
        public async Task<SampleDto> GetAsync()
        {
            return await _sampleAppService.GetAsync();
        }

        [HttpGet]
        [Route("myservice")]
        public async Task<PagedResultDto<ServiceDto>> GetServiceAsync()
        {
            return await _serviceAppService.GetListAsync(new GetServiceListDto());
        }

        [HttpPost]
        [Route("service")]
        public async Task<ServiceDto> Createservice(CreateServiceDto input)
        {
            return await _serviceAppService.CreateAsync(input);
        }

        [HttpGet]
        [Route("authorized")]
        [Authorize]
        public async Task<SampleDto> GetAuthorizedAsync()
        {
            return await _sampleAppService.GetAsync();
        }
     
    }
}
