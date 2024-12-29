namespace RECIPE_MANAGEMENT_SYSTEM.DTOs.RecipeDTOs
{
    public record RecipeDto
    (
        int Id,
        string Title,
        string Instructions,
        int PreparationTime,
        int CookingTime,
        List<string> Ingredients
    );
}
