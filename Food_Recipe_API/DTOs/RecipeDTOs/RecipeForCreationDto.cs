namespace RECIPE_MANAGEMENT_SYSTEM.DTOs.RecipeDTOs
{
    public record RecipeForCreationDto
    (
        string Title,
        string Instructions,
        int PreparationTime,
        int CookingTime,
        List<string> Ingredients
    );
}
