using System.ComponentModel.DataAnnotations.Schema;

namespace Food_Recipe_API.Models
{
    [Table("Recipes")]
    public class Recipe: BaseModel
    {
        public string Title { get; set; }
        public string Instructions { get; set; }
        public int PreparationTime { get; set; }
        public int CookingTime { get; set; }
        public List<string> Ingredients { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Favorite> FavoriteRecipes { get; set; }
        public Guid? UserId { get; set; }
        public Guid CategoryId { get; set; }
        public virtual User? User { get; set; }
        public virtual Category? Category { get; set; }
    }
}
