using Food_Recipe_API.Models;
using Microsoft.EntityFrameworkCore;
using RECIPE_MANAGEMENT_SYSTEM.Contracts;
using RECIPE_MANAGEMENT_SYSTEM.Data;

namespace RECIPE_MANAGEMENT_SYSTEM.Repository
{
    public class RecipeRepository : GenericRepository<Recipe>, IRecipeRepository
    {
        public RecipeRepository(RecipeDBContext recipeDBContext) : base(recipeDBContext)
        {

        } 
        public void CreateRecipeAsync(Recipe recipe) => Create(recipe);

        public void DeleteRecipeAsync(Recipe recipe) => Delete(recipe);
        public async Task<IEnumerable<Recipe>> GetAllRecipesAsync(bool trackChanges) => await FindAll(trackChanges).ToListAsync();

        public async Task<Recipe> GetRecipeAsync(int recipeId, bool trackChanges) => await FindByCondition(recipe => recipe.Id.Equals(recipeId), trackChanges).SingleOrDefaultAsync();

        public void UpdateRecipeAsync(Recipe recipe) => Update(recipe);
    }
}
