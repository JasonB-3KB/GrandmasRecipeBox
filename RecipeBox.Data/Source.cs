﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBox.Data
{
    public class Source
    {
        [Key]
        public int SourceId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Origin { get; set; }

    }
}
