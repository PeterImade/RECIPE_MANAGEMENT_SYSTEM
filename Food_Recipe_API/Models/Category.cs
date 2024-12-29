using System.ComponentModel.DataAnnotations.Schema;

namespace Food_Recipe_API.Models
{
    [Table("Categories")]
    public class Category: BaseModel
    {
        public string? Name { get; set; }
        public virtual ICollection<Recipe>? Recipes { get; set; }
    }
}
