using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class ReplyEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Text { get; set; } 

        [Required]
        [ForeignKey("Users")]
        public int AuthorId { get; set; }

        [Required]
        [ForeignKey("Comments")]
        public int ParentId { get; set; }
    }
}