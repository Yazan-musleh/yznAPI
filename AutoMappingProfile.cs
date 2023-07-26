using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using yzn_web.Domain.Model.Dto;
using yzn_web.Domain.Model.Entities;

namespace yzn_web
{
    public class AutoMappingProfile : Profile
    {
        public AutoMappingProfile()
        {
            CreateMap<BlogDto, Blog>();
            CreateMap<Blog, BlogDto>();
        }
    }
}