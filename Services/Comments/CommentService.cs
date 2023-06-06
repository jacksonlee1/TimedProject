using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Models.Comments;

namespace Services.Comments
{
    public class CommentService:ICommentService
    {
        private readonly ApplicationDbContext _db;

        public CommentService(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<bool> NewCommentAsync(CreateComment model)
        {
            var entity = new CommentEntity
            {
                Text = model.Text,
                AuthorId = model.AuthorId,
                PostId = model.PostId
            };
            _db.Comments.Add(entity);
            var changes = await _db.SaveChangesAsync();
            return changes == 1;
            
        }

        public async Task<IEnumerable<CommentDetail>> GetCommentByIdAsync(int id)
        {
            return await _db.Comments.Where(c => c.PostId == id).Select(c => new CommentDetail{
                c.
            });
        }



    }
}