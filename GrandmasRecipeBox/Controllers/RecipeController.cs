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
        /// <summary>
        /// This allows the user to retreive a recipe
        /// </summary>
        /// <returns>All recipes in database</returns>
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

        /// <summary>
        /// This allows a user to post a recipe in the database
        /// </summary>
        /// <param name="recipe"></param>
        /// <returns>200 ok</returns>
        /// 
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
        /// <summary>
        /// The user can look for a specific recipe by it's recipeId
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Recipe that matches the recipeId</returns>
        /// 
        // Get by recipeId
        public IHttpActionResult Get(int id)
        {
            RecipeService recipeService = CreateRecipeService();
            var recipe = recipeService.GetRecipeById(id);
            return Ok(recipe);
        }
        /// <summary>
        /// The user can specify a specific source and retrieve the associated recipes
        /// </summary>
        /// <param name="SourceId"></param>
        /// <returns>All recipes matching the SourceId</returns>
        // Gets the recipes related to a specific sourceId
        //Get by SourceId
        public IHttpActionResult GetRecipesSourceId(int SourceId)
        {
            RecipeService recipeService = CreateRecipeService();
            var recipes = recipeService.GetRecipesSourceId(SourceId);
            return Ok(recipes);
        }
        /// <summary>
        /// The user can update the recipe
        /// </summary>
        /// <param name="recipe"></param>
        /// <returns>200 Ok</returns>
        //Put a recipe 
        public IHttpActionResult Put(RecipeEdit recipe)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateRecipeService();

            if (!service.EditRecipe(recipe))
                return InternalServerError();

            return Ok();
        }
        /// <summary>
        /// Permanently delete a recipe by recipeId
        /// </summary>
        /// <param name="id"></param>
        /// <returns>200 Ok</returns>
        // Delete Recipe
        public IHttpActionResult Delete(int id)
        {
            var service = CreateRecipeService();

            if (!service.DeleteRecipe(id))
                return InternalServerError();
            return Ok();
        }
    }
}
