using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBox.Models
{
    public class CommentItem
    {
        public int CommentId { get; set; }
        public string Text { get; set; }
        
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
