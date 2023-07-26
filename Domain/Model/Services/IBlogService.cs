using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yzn_web.Domain.Model.Dto;
using yzn_web.Domain.Model.Entities;
using yzn_web.Domain.Model.Services.Communication;

namespace yzn_web.Domain.Model.Services
{
    public interface IBlogService
    {
        Task<ServiceResponse<BlogDto>> GetBlogById(int id);
        Task<ServiceResponse<List<BlogDto>>> GetBlogs();


        //---- ADMIN PROCESSES ----\\

        Task<ServiceResponse<List<Blog>>> CreateBlog(BlogDto blogDto);
        Task<ServiceResponse<Blog>> UpdateBlog(BlogDto blogDto, int id);
        Task<ServiceResponse<Blog>> DeleteBlog(int Id);
    }
}