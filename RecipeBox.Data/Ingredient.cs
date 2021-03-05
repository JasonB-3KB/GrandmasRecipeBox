using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBox.Data
{
    
    public class Ingredient
    {
        [Key]
        public int IngredientId { get; set; }

        [Required]
        public string IngredientName { get; set; }

        public Guid OwnerId { get; set; }
        
    }
}
