using RECIPE_MANAGEMENT_SYSTEM.Contracts;
using RECIPE_MANAGEMENT_SYSTEM.Data;

namespace RECIPE_MANAGEMENT_SYSTEM.Repository
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly RecipeDBContext _recipeDBContext;
        private readonly Lazy<IUserRepository> _userRepository;
        private readonly Lazy<IRecipeRepository> _recipeRepository;
        private readonly Lazy<IRatingRepository> _ratingRepository;
        private readonly Lazy<INotificationRepository> _notificationRepository;
        private readonly Lazy<IFollowRepository> _followRepository;
        private readonly Lazy<IFavoriteRepository> _favoriteRepository;
        private readonly Lazy<ICommentRepository> _commentRepository;
        private readonly Lazy<ICategoryRepository> _categoryRepository; 

        public UnitOfWork(RecipeDBContext recipeDBContext)
        {
            this._recipeDBContext = recipeDBContext;
            this._userRepository = new Lazy<IUserRepository>(() => new UserRepository(recipeDBContext));
            this._recipeRepository = new Lazy<IRecipeRepository>(() => new RecipeRepository(recipeDBContext));
            this._ratingRepository = new Lazy<IRatingRepository>(() => new RatingRespository(recipeDBContext));
            this._notificationRepository = new Lazy<INotificationRepository>(() => new NotificationRepository(recipeDBContext));
            this._followRepository = new Lazy<IFollowRepository>(() => new FollowRepository(recipeDBContext));
            this._favoriteRepository = new Lazy<IFavoriteRepository>(() => new FavoriteRepository(recipeDBContext));
            this._commentRepository = new Lazy<ICommentRepository>(() => new CommentRepository(recipeDBContext));
            this._categoryRepository = new Lazy<ICategoryRepository>(() => new CategoryRepository(recipeDBContext));
        }
        public IUserRepository Users => _userRepository.Value;

        public IRecipeRepository Recipes => _recipeRepository.Value;

        public IRatingRepository Ratings => _ratingRepository.Value;

        public INotificationRepository Notifications => _notificationRepository.Value;

        public IFollowRepository Follows => _followRepository.Value;

        public IFavoriteRepository Favorites => _favoriteRepository.Value;

        public ICommentRepository Comments => _commentRepository.Value;

        public ICategoryRepository Categories => _categoryRepository.Value;

        public async Task CommitAndSaveAsync()
        {
            await _recipeDBContext.SaveChangesAsync();
        }

        public async void Dispose()
        {
            await _recipeDBContext.DisposeAsync();
            GC.SuppressFinalize(this);
        }
    }
}
