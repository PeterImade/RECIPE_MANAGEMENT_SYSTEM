using System.ComponentModel.DataAnnotations.Schema;

namespace Food_Recipe_API.Models
{
    [Table("Comments")]
    public class Comment: BaseModel
    {
        public Guid UserId { get; set; }
        public Guid RecipeId { get; set; }
        public string Content { get; set; }
        public virtual Recipe? Recipe { get; set; }
        public virtual User? User { get; set; }
    }
}
