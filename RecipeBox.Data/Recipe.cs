using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBox.Data
{
    public class Recipe
    {

        [Key]
        public int RecipeId { get; set; }
        [Required]
        public string RecipeName { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
        [Required]
        public string Instructions { get; set; }
        [ForeignKey(nameof(Source))]
        public int SourceId { get; set; }
        public virtual Source Source { get; set; }
        public CuisineCategory TypeOfCuisine { get; set; }
        public DishType TypeOfDish { get; set; }
    }
    public enum CuisineCategory
    {
        African = 1,
        American,
        Asian,
        Australian,
        Austrian,
        Belgian,
        Brazilian,
        British,
        Cajun,
        Carribean,
        Central_American,
        Chinese,
        Creole,
        Cuban,
        Eastern_European,
        Filipino,
        French,
        Greek,
        Icelandic,
        Indian,
        Indonesian,
        Irish,
        Italian,
        Japanese,
        Jewish,
        Korean,
        Latin_American,
        Malaysian,
        Mediterranean,
        Mexican,
        Middle_Eastern,
        Moroccan,
        New_England,
        Pakistani,
        Portuguese,
        Provencal,
        Russian,
        Scandinavian,
        South_American,
        Southern,
        Southwestern,
        Spanish,
        Thai,
        Tibetan,
        Turkish,
        Vietnamese
    }
    public enum DishType
    {
        Salad = 1,
        Side,
        Main,
        Dessert,
        Soup,
        Appetizer



    }
}
