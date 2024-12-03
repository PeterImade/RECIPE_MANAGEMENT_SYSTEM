using System.ComponentModel.DataAnnotations.Schema;

namespace Food_Recipe_API.Models
{
    [Table("FavoriteRecipes")]
    public class Favorite: BaseModel
    {
        public string Title { get; set; }
        public Guid RecipeId { get; set; }
        public Guid UserId { get; set; } 
        public virtual User? User { get; set; }
        public virtual Recipe? Recipe { get; set; }
    }
}
