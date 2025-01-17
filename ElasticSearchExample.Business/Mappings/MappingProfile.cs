using ElasticSearchExample.Entities.Concrete.Posts;
using ElasticSearchExample.Entities.DTOs.Posts;
using AutoMapper;

namespace ElasticSearchExample.Business.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Post, PostInputDto>().ReverseMap();
        }
    }
}
