

namespace Services.Posts;

public interface IPostService
{
    Task<bool>CreatePostAsync(PostCreate request);
}