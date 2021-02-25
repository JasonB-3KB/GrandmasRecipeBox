using RecipeBox.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBox.Models
{
    public class RecipeUpdate
    {
        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public string Instructions { get; set; }
        public int SourceId { get; set; }
        public string Ingredients { get; set; }
        public CuisineCategory TypeOfCuisine { get; set; }
        public DishType TypeOfDish { get; set; }
    }
}

