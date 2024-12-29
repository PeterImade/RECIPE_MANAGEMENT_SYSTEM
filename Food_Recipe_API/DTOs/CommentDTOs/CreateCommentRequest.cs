namespace RECIPE_MANAGEMENT_SYSTEM.DTOs.CommentDTOs
{
    public record CreateCommentRequest
    ( 
        string Content,
        int RecipeId,
        string UserId
    );
}
