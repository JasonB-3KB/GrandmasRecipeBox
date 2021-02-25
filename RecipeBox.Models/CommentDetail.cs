using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBox.Models
{
    public class CommentDetail
    {
        public int CommentId { get; set; }
        public string Text { get; set; }
        [Display(Name = "Comment Created")]
        public DateTimeOffset CreatedUtc { get; set; }
        [Display(Name = "Comment Modified")]
        public DateTimeOffset ModifiedUtc { get; set; }
    }
}
