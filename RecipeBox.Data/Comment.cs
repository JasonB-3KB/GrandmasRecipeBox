using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBox.Data
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        [ForeignKey("Recipe")]
        public int RecipeId { get; set; }
        public Guid OwnerId { get; set; }
        [Required]
        public string Text { get; set; }


        [Display(Name = "Comment Created")]
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
