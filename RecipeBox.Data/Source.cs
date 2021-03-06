using System;
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
        
        public Guid OwnerId { get; set; }

        [Required]
        public string SourceName { get; set; }

        [Required]
        public string SourceOrigin { get; set; }

    }
}
