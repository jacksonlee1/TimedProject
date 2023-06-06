using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Microsoft.AspNetCore.Mvc;
using Models.Comments;
using Services.Comments;

namespace WebAPI.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class CommentController:ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private readonly ICommentService _commentService;

        public CommentController(ApplicationDbContext db, ICommentService commentService)
        {
            _db = db;
            _commentService = commentService;
        }

        [HttpPost]
        public async Task<IActionResult> NewComment([FromBody]CreateComment req)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);

            var res = await _commentService.NewCommentAsync(req);
            if(res) return Ok();
            return BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> GetCommentByPostId([FromRoute]int id)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);

            return Ok(await _commentService.GetCommentsByPostIdAsync(id));

        }
    }
}