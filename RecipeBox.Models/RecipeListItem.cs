using RecipeBox.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBox.Models
{
    public class RecipeListItem
    {
        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public CuisineCategory  TypeOfCuisine { get; set; }
        public DishType TypeOfDish { get; set; }
    }
}
