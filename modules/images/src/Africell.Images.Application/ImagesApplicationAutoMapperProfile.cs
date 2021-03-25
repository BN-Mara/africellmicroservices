using Africell.Images.Images;
using AutoMapper;

namespace Africell.Images
{
    public class ImagesApplicationAutoMapperProfile : Profile
    {
        public ImagesApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Image, ImageDto>();
            CreateMap<CreateUpdateImageDto, Image>();
        }
    }
}