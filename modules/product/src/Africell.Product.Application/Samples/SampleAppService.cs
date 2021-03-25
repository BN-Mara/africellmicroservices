using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Africell.Product.Samples
{
    public class SampleAppService : ProductAppService, ISampleAppService
    {
        //private readonly IRepository<Sample,Guid>
        public Task<SampleDto> GetAsync()
        {
            return Task.FromResult(
                new SampleDto
                {
                    Value = 42
                }
            );
        }
       
        
        

        [Authorize]
        public Task<SampleDto> GetAuthorizedAsync()
        {
            return Task.FromResult(
                new SampleDto
                {
                    Value = 42
                }
            );
        }
    }
}