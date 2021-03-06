using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBox.Models
{
    public class CommentCreate
    {
        
        public int CommentId { get; set; }
        
        [MaxLength(8000)]
        public string Text { get; set; }
        
        public int RecipeId { get; set; }
        
        public DateTimeOffset CreatedUtc { get; set; }

    }
}
