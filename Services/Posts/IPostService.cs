

using Models.Posts;

namespace Services.Posts;

public interface IPostService
{
    Task<bool> CreatePostAsync(PostCreate request);

    Task<IEnumerable<PostList>> GetAllPostsAsync(int id);
}