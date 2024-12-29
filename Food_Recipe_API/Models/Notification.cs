using System.ComponentModel.DataAnnotations.Schema;
using Food_Recipe_API.DTOs;

namespace Food_Recipe_API.Models
{
    [Table("Notifications")]
    public class Notification: BaseModel
    {
        public NotificationType Type { get; set; }
        public string? Message { get; set; }
        public int RecipeId { get; set; }
        public string? UserId { get; set; }
        public virtual Recipe? Recipe { get; set; }
        public virtual User? User { get; set; }
    }
}
