using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using yzn_web.Domain.Model.Dto;
using yzn_web.Domain.Model.Entities;
using yzn_web.Domain.Model.Repositories;
using yzn_web.Domain.Model.Services;
using yzn_web.Domain.Model.Services.Communication;
using yzn_web.Persistance.Context;

namespace yzn_web.Services.BlogServices
{
    public class BlogService : IBlogService
    {
        private readonly IMapper _mapper;
        private readonly IBlogRepo _repo;
        private readonly IUnitOfWork _workUnit;

        public BlogService(IMapper mapper, IBlogRepo repo, IUnitOfWork workUnit)
        {
            this._workUnit = workUnit;
            this._repo = repo;
            _mapper = mapper;
        }
        public async Task<ServiceResponse<List<Blog>>> CreateBlog(BlogDto blogDto)
        {
            var blog = _mapper.Map<Blog>(blogDto);

            await _repo.AddBlog(blog);

            await _workUnit.SaveAsync();

            var blogs = await _repo.GetBlogs();

            return new ServiceResponse<List<Blog>>(blogs, "Blog was added successfully");
        }


        public async Task<ServiceResponse<Blog>> DeleteBlog(int id)
        {
            var existingBlog = await _repo.GetBlog(id);

            if (existingBlog is null)
            {
                return new ServiceResponse<Blog>($"Blog with {id} does'nt exist");
            }

            _repo.DeleteBlog(existingBlog);
            await _workUnit.SaveAsync();

            return new ServiceResponse<Blog>(existingBlog, "Blog deleted successfully");
        }


        public Task<ServiceResponse<BlogDto>> GetBlogById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<BlogDto>>> GetBlogs()
        {
            var request = await _repo.GetBlogs();
            var blogs = _mapper.Map<List<BlogDto>>(request);
            return new ServiceResponse<List<BlogDto>>(blogs , "Got blogs successfully");
        }

        public Task<ServiceResponse<Blog>> UpdateBlog(BlogDto blogDto, int id)
        {
            throw new NotImplementedException();
        }
    }
}