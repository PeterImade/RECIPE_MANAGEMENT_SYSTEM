using RECIPE_MANAGEMENT_SYSTEM.DTOs.RecipeDTOs;

namespace RECIPE_MANAGEMENT_SYSTEM.Services.Contracts
{
    public interface IRecipeService
    {
        Task<RecipeDto> CreateRecipeAsync(RecipeForCreationDto recipeForCreationDto);
        Task<RecipeDto> GetRecipeAsync(int recipeId, bool trackChanges);
        Task<IEnumerable<RecipeDto>> GetAllRecipesAsync(bool trackChanges);
        Task<RecipeDto> UpdateRecipeAsync(int recipeId, RecipeForUpdateDto recipeForUpdateDto, bool trackChanges);
        Task DeleteRecipeAsync(int recipeId, bool trackChanges);

    }
}