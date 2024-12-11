using Food_Recipe_API.Models;
using RECIPE_MANAGEMENT_SYSTEM.Contracts;
using RECIPE_MANAGEMENT_SYSTEM.Data;

namespace RECIPE_MANAGEMENT_SYSTEM.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(RecipeDBContext recipeDBContext) : base(recipeDBContext)
        {
        }
    }
}
