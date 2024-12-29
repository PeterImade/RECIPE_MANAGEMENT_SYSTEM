using RECIPE_MANAGEMENT_SYSTEM.Contracts;

namespace RECIPE_MANAGEMENT_SYSTEM.Services.Contracts
{
    public class ServiceManager : IServiceManager
    {
        public readonly Lazy<IRecipeService> _recipeService;
        public ServiceManager(IUnitOfWork unitOfWork)
        {
            _recipeService = new Lazy<IRecipeService>(() => new RecipeService(unitOfWork));
        }
        public IRecipeService RecipeService => _recipeService.Value;

        public ICategoryService CategoryService => throw new NotImplementedException();

        public ICommentService CommentService => throw new NotImplementedException();

        public IRatingService RatingService => throw new NotImplementedException();

        public INotificationService NotificationService => throw new NotImplementedException();

        public IUserService UserService => throw new NotImplementedException();

    
    }
}
