using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class PostEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } 

        [Required]
        public string Text { get; set; } 

        [Required]
        public string Url { get; set; } 

        [Required]
        [ForeignKey("Users")]
        public int AuthorId { get; set; }

        public virtual List<LikeEntity> LikeEntity { get; set; } = new();
    }
}