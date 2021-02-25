using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBox.Data
{
    class RecipeContent
    {
        public int RecipeId { get; set; }
        public int IngredientId { get; set; }
        public string IngredientQuantity { get; set; }
    }
}
