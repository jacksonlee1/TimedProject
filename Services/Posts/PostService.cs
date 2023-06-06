

namespace Services.Posts;

public class PostService : IPostService
{
    private readonly ApplicationDbContext _context;

    public PostService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> CreatePostAsync(CreateRegister model)
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
        var notes = await _context.Posts
        .Where(entity => entity.AuthorId == id)
        .Select(entity => new PostListItem
        {
            Id = entity.Id,
            Title = entity.Title,
           

        })
         .ToListAsync();

        return Posts;

    }
}