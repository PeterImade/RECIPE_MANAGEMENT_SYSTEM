using Food_Recipe_API.Models;
using RECIPE_MANAGEMENT_SYSTEM.Contracts;
using RECIPE_MANAGEMENT_SYSTEM.Data;

namespace RECIPE_MANAGEMENT_SYSTEM.Repository
{
    public class RatingRespository : GenericRepository<Rating>, IRatingRepository
    {
        public RatingRespository(RecipeDBContext recipeDBContext) : base(recipeDBContext)
        {
        }
    }
}
