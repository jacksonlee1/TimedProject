using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class CommentEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Text { get; set; } 

        [Required]
        [ForeignKey("User")]
        public int AuthorId { get; set; }

        [Required]
        [ForeignKey("Posts")]
        public int PostId { get; set; }

        public virtual List<ReplyEntity> ReplyEntity { get; set; } = new();
    }
}