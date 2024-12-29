namespace RECIPE_MANAGEMENT_SYSTEM.DTOs.CommentDTOs
{
    public record CommentResponse
    (
        int Id,
        string Content,
        int RecipeId,
        string UserId
    );
}
