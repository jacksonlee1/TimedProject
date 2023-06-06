
using System.ComponentModel.DataAnnotations;

namespace Models.Replies;

public class CreateReply
{
    [Required]
    public string Text { get; set; } = string.Empty;

    [Required]
    public int ParentId { get; set; }

    [Required]

    public int AuthorId { get; set; }
}