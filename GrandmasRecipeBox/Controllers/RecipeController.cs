using RecipeBox.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RecipeBox.Models;

namespace GrandmasRecipeBox.Controllers
{
    [Authorize]
    public class RecipeController : ApiController
    {
        // Get all recipes
        public IHttpActionResult Get()
        {
            RecipeService recipeService = CreateRecipeService();
            var recipes = recipeService.GetRecipes();
            return Ok(recipes);
        }
        private RecipeService CreateRecipeService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var recipeServices = new RecipeService(userId);
            return recipeServices;
        }
        // Post a recipe
        public IHttpActionResult Post(RecipeCreate recipe)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateRecipeService();

            if (!service.CreateRecipe(recipe))
                return InternalServerError();

            return Ok();
        }
        // Get by recipeId
        public IHttpActionResult Get(int id)
        {
            RecipeService recipeService = CreateRecipeService();
            var recipe = recipeService.GetRecipeById(id);
            return Ok(recipe);
        }
        /*public IHttpActionResult GetRecipesSourceId(int SourceId)
        {
            RecipeService recipeService = CreateRecipeService();
            var recipes = recipeService.GetRecipesSourceId(SourceId);
            return Ok(recipes);
        }*/
        public IHttpActionResult Put(RecipeEdit recipe)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateRecipeService();

            if (!service.EditRecipe(recipe))
                return InternalServerError();

            return Ok();
        }
        public IHttpActionResult Delete(int id)
        {
            var service = CreateRecipeService();

            if (!service.DeleteRecipe(id))
                return InternalServerError();
            return Ok();
        }
    }
}
