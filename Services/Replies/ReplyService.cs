
using Data;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Models.Replies;

namespace Services.Replies;

public class ReplyService : IReplyService


{

    private readonly ApplicationDbContext _context;

    public ReplyService(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<bool> CreateReplyAsync(CreateReply model)

    {



        var entity = new ReplyEntity
        {
            Text = model.Text,
            ParentId = model.ParentId,
            AuthorId = model.AuthorId
        };
        _context.Replies.Add(entity);
        var changes = await _context.SaveChangesAsync();
        return changes == 1;

    }

    public async Task<IEnumerable<ReplyDetail>> GetAllRepliesAsync(int commentId)
    {
        var replies = await _context.Replies.Where(r => r.ParentId == commentId).Select(r => new ReplyDetail
        {
            Text = r.Text,
            AuthorId = r.AuthorId
        })
        .ToListAsync();

        return replies;
    }




}