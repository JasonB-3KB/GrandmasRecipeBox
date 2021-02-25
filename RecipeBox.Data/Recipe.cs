using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBox.Data
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public int Servings { get; set; }

        // public string Ingredients { get; set; }
        public string Instructions { get; set; }

        //SourceId - ForeignKey
        //CategoryId - ForeignKey
    }
    // Not sure where this enum goes
    enum CuisineCategory
    {
        African,
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
    enum DishType
    {
        Salad,
        Side,
        Main,
        Dessert,
        Soup,
        Appetizer
    }

}
