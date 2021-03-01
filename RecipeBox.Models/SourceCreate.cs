using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBox.Models
{
    public class SourceCreate
    {
        [Required]
        public string SourceName { get; set; }

        [Required]
        public string SourceOrigin { get; set; }
    }
}
