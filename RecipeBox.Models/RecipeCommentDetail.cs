using RecipeBox.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBox.Models
{
    public class RecipeCommentDetail
    {
        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public int CommentId { get; set; }
        public string Text { get; set; }
        public CuisineCategory TypeOfCuisine { get; set; }
        public DishType TypeOfDish { get; set; }
        public string Instructions { get; set; }
        //public string Ingredients { get; set; }
    }
}
