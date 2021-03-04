using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBox.Data
{
    public class RecipeContent
    {
        [Key]
        public int RecipeContentId { get; set; }

        //[ForeignKey(nameof(Recipe))]
        //public int  RecipeId { get; set; }
        //public virtual Recipe Recipe { get; set; }


        [ForeignKey(nameof(Ingredient))]
        public int IngredientId { get; set; }
        public virtual Ingredient Ingredient { get; set; }

        [Required]
        public string IngredientQuantity { get; set; }
    }
}
