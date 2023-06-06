using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.Posts;
using Services.Posts;

namespace WebAPI.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

    [HttpPost]
        public async Task<IActionResult> CreatePost([FromBody] PostCreate model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var postResult = await _postService.CreatePostAsync(model);
            if (postResult)
            {
                return Ok("Your post has been created.");
            }

            return BadRequest("Failed to create post.");
        }

        [HttpGet("{AuthorId:int}")]
        public async Task<IActionResult> GetById([FromRoute] int AuthorId)
        {
            var postDetail = await _postService.GetAllPostsAsync(AuthorId);

            if(postDetail is null)
            {
                return NotFound();
            }

            return Ok(postDetail);
        }

    }
}