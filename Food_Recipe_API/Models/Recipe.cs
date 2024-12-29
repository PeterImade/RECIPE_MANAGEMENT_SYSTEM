using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Food_Recipe_API.Models
{
    [Table("Recipes")]
    public class Recipe: BaseModel
    {
        public string? Title { get; set; }
        public string? Instructions { get; set; }
        public int PreparationTime { get; set; }
        public int CookingTime { get; set; }
        public List<string>? Ingredients { get; set; }
        public virtual ICollection<Rating>? Ratings { get; set; }
        public virtual ICollection<Comment>? Comments { get; set; }
        public virtual ICollection<Notification>? Notifications { get; set; } 
        public string? UserId { get; set; }
        public int CategoryId { get; set; }
        public virtual User? User { get; set; }
        public virtual Category? Category { get; set; }
    }
}
