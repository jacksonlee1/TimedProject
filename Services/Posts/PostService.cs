

using Data;
using Models.Posts;

namespace Services.Posts;

public class PostService : IPostService
{
    private readonly ApplicationDbContext _context;

    public PostService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> CreatePostAsync(PostCreate model)
    {
        var entity = new PostEntity
        {
            Title = model.Title,
            Text = model.Text,
            AuthorId = model.AuthorId
        };

        _context.Posts.Add(entity);
        var numberOfChanges = await _context.SaveChangesAsync();

        return numberOfChanges == 1;
    }

    public async Task<IEnumerable<PostList>> GetAllPostsAsync(int id)
    {
        var posts = await _context.Posts
        .Where(entity => entity.AuthorId == id)
        .Select(entity => new PostList
        {
            Id = entity.Id,
            Title = entity.Title,


        })
         .ToListAsync();

        return posts;

    }
}