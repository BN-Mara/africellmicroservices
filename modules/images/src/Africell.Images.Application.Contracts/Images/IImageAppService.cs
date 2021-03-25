using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Africell.Images.Images
{
    public interface IImageAppService : ICrudAppService<ImageDto,Guid,PagedAndSortedResultRequestDto,CreateUpdateImageDto>
    {
    }
}
