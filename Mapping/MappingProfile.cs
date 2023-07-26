using AutoMapper;
using yzn_web.Domain.Model.Dto;
using yzn_web.Domain.Model.Entities;

namespace yzn_web.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile(){
            CreateMap<BlogDto, Blog>();
        }
    }
}