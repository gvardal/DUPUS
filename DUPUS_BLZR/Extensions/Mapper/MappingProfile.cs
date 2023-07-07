using AutoMapper;
using Entities.Dtos;
using Entities.Models;

namespace DUPUS_BLZR.Extensions.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UYKonum, GanttResourceGroupDto>();
            CreateMap<UYKonum, ResourceListDto>();
        }
    }
}
