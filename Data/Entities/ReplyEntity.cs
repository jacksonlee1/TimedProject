using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Key]
        public int AuthorId { get; set; }

        [Key]
        public int ParentId { get; set; }
    }
}