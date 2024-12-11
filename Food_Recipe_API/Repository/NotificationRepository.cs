using Food_Recipe_API.Models;
using RECIPE_MANAGEMENT_SYSTEM.Contracts;
using RECIPE_MANAGEMENT_SYSTEM.Data;

namespace RECIPE_MANAGEMENT_SYSTEM.Repository
{
    public class NotificationRepository : GenericRepository<Notification>, INotificationRepository
    {
        public NotificationRepository(RecipeDBContext recipeDBContext) : base(recipeDBContext)
        {
        }
    }
}
