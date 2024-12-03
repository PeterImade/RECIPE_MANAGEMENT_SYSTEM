using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Food_Recipe_API.Models
{
    [Table("Users")]
    public class User: BaseModel
    {   
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }
        public virtual ICollection<Recipe> Recipes { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<Following> Following { get; set; }
        public virtual ICollection<Following> Followers { get; set; }
        public virtual ICollection<Favorite> FavoriteRecipes { get; set; }
    }
}