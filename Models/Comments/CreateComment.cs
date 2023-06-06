using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Comments
{
    public class CreateComment
    {
        [Required]
        public string Text{get;set;}

        [Required]
        public string AuthorId{get;set;}

        [Required]
        public string PostId{get;set;}
        
    }
}