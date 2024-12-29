using Food_Recipe_API.Models;
using RECIPE_MANAGEMENT_SYSTEM.DTOs.RecipeDTOs;

namespace RECIPE_MANAGEMENT_SYSTEM.Contracts
{
    public interface IRecipeRepository
    {
        Task<Recipe> GetRecipeAsync(int recipeId, bool trackChanges);
        Task<IEnumerable<Recipe>> GetAllRecipesAsync(bool trackChanges);
        void CreateRecipeAsync(Recipe recipe);
        void DeleteRecipeAsync(Recipe recipe);
        void UpdateRecipeAsync(Recipe recipe);
    }
}