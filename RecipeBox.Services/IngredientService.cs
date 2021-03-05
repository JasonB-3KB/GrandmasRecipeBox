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
        private readonly Guid _userId;
        public IngredientService(Guid userId)
        {
            _userId = userId;
        }
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
            public IEnumerable<IngredientEdit> GetAllIngredients()
            {
                using (var ctx = new ApplicationDbContext())
                {
                    var query =
                        ctx
                            .Ingredients
                            .Select(
                                e =>
                                    new IngredientEdit
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
                    .SingleOrDefault();
                return query;
            }
        }
        
        public bool UpdateIngredient(IngredientEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Ingredients
                        .Single(e => e.IngredientId == model.IngredientId);

                entity.IngredientName = model.IngredientName;

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
