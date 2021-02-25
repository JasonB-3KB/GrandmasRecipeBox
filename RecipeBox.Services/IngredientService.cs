using RecipeBox.Data;
using RecipeBox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBox.Services
{
    public class IngredientService
    { 
        public bool CreateIngredient(IngredientCreate model)
        {
            var entity =
                new Ingredient()
                {
                    IngredientId = model.IngredientId,
                    IngredientName = model.IngredientName
                };
            ///////
                using (var ctx = new ApplicationDbContext())
                {
                    ctx.Ingredients.Add(entity);
                    return ctx.SaveChanges() == 1;
                }
        }
            public IEnumerable<Ingredient> GetAllIngredients()
            {
                using (var ctx = new ApplicationDbContext())
                {
                    var query =
                        ctx
                            .Ingredients
                            .Select(
                                e =>
                                    new Ingredient
                                    {
                                        IngredientId = e.IngredientId,
                                        IngredientName = e.IngredientName,
                                    }
                           );
                    return query.ToArray();
                }
            }
        public Ingredient GetIngredientById(int ingredientId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                ctx
                    .Ingredients
                    .Where(e => e.IngredientId == ingredientId)
                    .FirstOrDefault();
                return query;
            }
        }
        
    }
}
