﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBox.Models
{
    public class CommentCreate
    {
        [Key]
        public int CommentId { get; set; }
        [Required]
        [MaxLength(8000)]
        public string Text { get; set; }
        [Required]
        public int RecipeId { get; set; }
        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

    }
}
