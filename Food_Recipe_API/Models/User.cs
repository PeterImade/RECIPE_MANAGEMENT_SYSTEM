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
        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Recipe> Recipes { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<Follow> Following { get; set; } = new List<Follow>();
        public virtual ICollection<Follow> Followers { get; set; } = new List<Follow>();
        public virtual ICollection<Favorite> FavoriteRecipes { get; set; }
    }
}