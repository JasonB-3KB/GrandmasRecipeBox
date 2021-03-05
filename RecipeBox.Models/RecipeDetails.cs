using RecipeBox.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBox.Models
{
    public class RecipeDetails
    {
        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        //public int SourceId { get; set; }
        //public string SourceName { get; set; }
        public string Instructions { get; set; }
<<<<<<< HEAD
        public string CommentText { get; set; }
        public int MyProperty { get; set; }
=======
        //public int MyProperty { get; set; }
>>>>>>> 0a4aae2383ef581ca34cb9487a402295641c7367
        public CuisineCategory TypeOfCuisine { get; set; }
        public DishType TypeOfDish { get; set; }
    }
}
