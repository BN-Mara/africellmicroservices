using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Africell.Images.Images
{
    public class ImageAppService :
        CrudAppService<Image,ImageDto,Guid,PagedAndSortedResultRequestDto,CreateUpdateImageDto>,IImageAppService
    {
        public ImageAppService(IRepository<Image,Guid> repository) : base(repository)
        {

        }
    }
}
