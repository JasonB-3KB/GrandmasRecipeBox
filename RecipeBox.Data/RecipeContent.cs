using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBox.Data
{
    public class RecipeContent
    {
        [ForeignKey(nameof(Recipe))]
        public int RecipeId { get; set; }

        [ForeignKey(nameof(Ingredient))]
        public int IngredientId { get; set; }
        public string IngredientQuantity { get; set; }
    }
}
