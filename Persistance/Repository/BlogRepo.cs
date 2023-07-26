using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using yzn_web.Domain.Model.Entities;
using yzn_web.Domain.Model.Repositories;
using yzn_web.Persistance.Context;

namespace yzn_web.Persistance.Repository
{
    public class BlogRepo : IBlogRepo
    {
        private readonly DataContext _context;

        public BlogRepo(DataContext context)
       {
            _context = context;
        }

        public async Task<Blog> GetBlog(int id)
        {
            return await _context.Blogs.FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<List<Blog>> GetBlogs()
        {
            return await _context.Blogs.ToListAsync();
        }



        // ------ ADMIN PROCESSES ------ \\

        public async Task<List<Blog>> AddBlog(Blog blog)
        {
            await _context.Blogs.AddAsync(blog);
            return await GetBlogs();
        }

        public void UpdateBlog(Blog blog)
        {
            throw new NotImplementedException();
        }
        
       
        public void DeleteBlog(Blog blog)
        {
            _context.Blogs.Remove(blog);
        }
    }
}