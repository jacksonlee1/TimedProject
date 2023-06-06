using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models.Comments;

namespace Services.Comments
{
    public interface ICommentService
    {
        Task<bool> NewCommentAsync(CreateComment model);

        Task<IEnumerable<CommentDetail>> GetCommentsByPostIdAsync(int postId);
        
    }
}