namespace RECIPE_MANAGEMENT_SYSTEM.DTOs.RatingDTOs
{
    public record RatingResponse
    (
        int Id,
        string UserId,
        int RatingValue,
        int RecipeId
    );
}
