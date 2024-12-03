using System.ComponentModel.DataAnnotations.Schema;

namespace Food_Recipe_API.Models
{
    [Table("Ratings")]
    public class Rating: BaseModel
    {
        public Guid UserId { get; set; }
        public Guid RecipeId { get; set; }
        public int RatingValue { get; set; }
        public virtual User? User { get; set; }
        public virtual Recipe? Recipe { get; set; }
    }
}