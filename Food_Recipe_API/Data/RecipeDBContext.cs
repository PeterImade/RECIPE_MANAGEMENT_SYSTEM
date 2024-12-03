using Food_Recipe_API.Models;
using Microsoft.EntityFrameworkCore;
using RECIPE_MANAGEMENT_SYSTEM.Configurations;

namespace RECIPE_MANAGEMENT_SYSTEM.Data
{
    public class RecipeDBContext: DbContext
    {
        public RecipeDBContext(DbContextOptions<RecipeDBContext> options): base(options)
        {
            
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Recipe> Recipes { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<Following> Followings { get; set; }
        public virtual DbSet<Favorite> Favorites { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfig());
        }

    }
}
