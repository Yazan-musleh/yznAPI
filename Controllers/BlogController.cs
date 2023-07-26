using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using yzn_web.Domain.Model.Dto;
using yzn_web.Domain.Model.Entities;
using yzn_web.Domain.Model.Services;

namespace yzn_web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogController : ControllerBase
    {
        private readonly IBlogService _service;

        public BlogController(IBlogService service)
        {
            this._service = service;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BlogDto>> GetBlogs(int id)
        {
            var result = await _service.GetBlogById(id);

            if (!result.Success)
            {
                return BadRequest("Could'nt get the blog");
            }
            return Ok(result);
        }

        [HttpGet("blogs")]
        public async Task<ActionResult<List<BlogDto>>> GetBlogs() {
            var result = await _service.GetBlogs();

            if (!result.Success)
            {
                return BadRequest("Could'nt get the blogs");
            }
            return Ok(result);
        }

        [HttpPost()]
        public async Task<ActionResult<List<BlogDto>>> CreateBlog(BlogDto blogDto){
            var result = await _service.CreateBlog(blogDto);

            if (!result.Success)
            {
                return BadRequest("There was an error creating the blog");
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Blog>> DeleteBlog(int id){
            var result = await _service.DeleteBlog(id);

            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result);
        }


    }
}