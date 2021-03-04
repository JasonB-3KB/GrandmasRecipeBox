using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipeBox.Data;
using RecipeBox.Models;

namespace RecipeBox.Services
{
    public class RecipeContentService
    {
        //DONE: Add recipeId to RecipeContentCreate class
        public bool CreateRecipeContent(RecipeContentCreate model)
        {
            var entity = new RecipeContent()
            {
                RecipeContentId = model.RecipeContentId,
                //RecipeId = model.RecipeId,
                IngredientId = model.IngredientId,
                IngredientQuantity = model.IngredientQuantity,
            };

            using (var ctx = new ApplicationDbContext())
            {
                var recipe = ctx.Recipes.Single(x => x.RecipeId == model.RecipeId);
                recipe.RecipeContent.IngredientQuantity = model.IngredientQuantity;

                ctx.RecipeContents.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        private readonly Guid _userId;
        public RecipeContentService(Guid userId)
        {
            _userId = userId;
        }
        //Add(join/link) Ingredient to Recipe

        //Edit(update) Ingredient in Recipe

        //Edit(update) Quantity to Ingredient by Recipe



    }
}