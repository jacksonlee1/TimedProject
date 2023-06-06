

using Models.Replies;

namespace Services.Replies;

public interface IReplyService
{
    Task<bool> CreateReplyAsync(CreateReply model);
    Task<IEnumerable<ReplyDetail>> GetAllRepliesAsync(int commentId);

}


