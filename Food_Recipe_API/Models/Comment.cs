using System.ComponentModel.DataAnnotations.Schema;

namespace Food_Recipe_API.Models
{
    [Table("Comments")]
    public class Comment: BaseModel
    {
        public string? Content { get; set; }
        public virtual Recipe? Recipe { get; set; }
        public int RecipeId { get; set; }
        public string? UserId { get; set; }
        public virtual User? User { get; set; }
    }
}