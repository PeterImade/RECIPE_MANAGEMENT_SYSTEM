using Food_Recipe_API.Models;

namespace RECIPE_MANAGEMENT_SYSTEM.DTOs.CategoryDTOs
{
    public record CreateCategoryRequest
    (   
        string Name,
        ICollection<Recipe> Recipes
    );
   
}
