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
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

    [HttpPost("Post")]
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

        [Authorize]
        [HttpGet("{PostId:int}")]
        public async Task<IActionResult> GetById([FromRoute] int PostId)
        {
            var postDetail = await _postService.GetAllPostsAsync(PostId);

            if(postDetail is null)
            {
                return NotFound();
            }

            return Ok(postDetail);
        }

    }
}