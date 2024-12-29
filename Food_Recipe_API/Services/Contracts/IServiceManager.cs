namespace RECIPE_MANAGEMENT_SYSTEM.Services.Contracts
{
    public interface IServiceManager
    {
        IRecipeService RecipeService { get; }
        ICategoryService CategoryService { get; }
        ICommentService CommentService { get; }
        IRatingService RatingService { get; }
        INotificationService NotificationService { get; }
        IUserService UserService { get; }
    }
}
