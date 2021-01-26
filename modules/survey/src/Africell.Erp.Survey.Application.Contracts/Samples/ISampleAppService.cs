using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Africell.Erp.Survey.Samples
{
    public interface ISampleAppService : IApplicationService
    {
        Task<SampleDto> GetAsync();

        Task<SampleDto> GetAuthorizedAsync();
    }
}
