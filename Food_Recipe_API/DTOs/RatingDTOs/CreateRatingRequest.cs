namespace RECIPE_MANAGEMENT_SYSTEM.DTOs.RatingDTOs
{
    public record CreateRatingRequest
    (
        string UserId,
        int RecipeId,
        int RatingValue
    );
}
