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
        // stretch goal
        // public int Kcal { get; set; }
        // public int Protein { get; set; }
        // public int Carbs { get; set; }
        // public int Fat { get; set; }
    }
}
