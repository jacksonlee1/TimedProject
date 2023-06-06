using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.Replies;
using Services.Replies;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ReplyController : ControllerBase
    {
        private readonly IReplyService _reply;

        public ReplyController(IReplyService reply)
        {
            _reply = reply;
        }

        [HttpPost("Reply")]
        public async Task<IActionResult> CreateReply([FromBody] CreateReply model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var replyResult = await _reply.CreateReplyAsync(model);
            if (replyResult)
            {
                return Ok("Your reply has been posted.");
            }

            return BadRequest("Failed to post reply.");
        }

        [Authorize]
        [HttpGet("{ReplyId:int}")]
        public async Task<IActionResult> GetById([FromRoute] int ReplyId)
        {
            var replyDetail = await _reply.GetAllRepliesAsync(ReplyId);

            if(replyDetail is null)
            {
                return NotFound();
            }

            return Ok(replyDetail);
        }
    }
}