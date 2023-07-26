using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using yzn_web.Domain.Model.Entities;

namespace yzn_web.Domain.Model.Repositories
{
    public interface IBlogRepo
    {
        Task<Blog> GetBlog(int id);
        Task<List<Blog>> GetBlogs();
        

        // ------ ADMIN PROCESSES ------- \\

        Task<List<Blog>> AddBlog(Blog blog);
        void UpdateBlog(Blog blog);
        void DeleteBlog(Blog blog);
    }
}