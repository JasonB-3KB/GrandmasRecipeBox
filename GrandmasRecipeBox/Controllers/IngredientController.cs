using Microsoft.AspNet.Identity;
using RecipeBox.Models;
using RecipeBox.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GrandmasRecipeBox.Controllers
{
    [Authorize]
    public class IngredientController : ApiController
    {
        public IHttpActionResult Get()
        {
            IngredientService ingredientService = CreateIngredientService();
            var ingredients = ingredientService.GetAllIngredients();
            return Ok(ingredients);
        }

        public IHttpActionResult Get(int id)
        {
            IngredientService ingredientService = CreateIngredientService();
            var ingredient = ingredientService.GetIngredientById(id);
            return Ok(ingredient);
        }

        public IHttpActionResult Post(IngredientCreate ingredient)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateIngredientService();

            if (!service.CreateIngredient(ingredient))
                return InternalServerError();

            return Ok();
        }
        private IngredientService CreateIngredientService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var ingredientService = new IngredientService(userId);
            return ingredientService;
        }
    }
}

