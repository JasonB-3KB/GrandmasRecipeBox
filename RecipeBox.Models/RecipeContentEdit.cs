using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBox.Models
{
    class RecipeContentEdit
    {
        public int RecipeContentId { get; set; }
        public int IngredientId { get; set; }
        public string IngredientQuantity { get; set; }
    }
}
