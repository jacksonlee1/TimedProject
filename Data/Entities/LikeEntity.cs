using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class LikeEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Posts")]
        public int UserId { get; set; }
        
        public int PostId { get; set; }
    }
}