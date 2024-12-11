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
        public virtual DbSet<Follow> Followings { get; set; }
        public virtual DbSet<Favorite> Favorites { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new RecipeConfig());
            modelBuilder.ApplyConfiguration(new RatingConfig());
            modelBuilder.ApplyConfiguration(new NotificationConfig());
            modelBuilder.ApplyConfiguration(new FollowConfig());
            modelBuilder.ApplyConfiguration(new FavoriteConfig());
            modelBuilder.ApplyConfiguration(new CommentConfig());
            modelBuilder.ApplyConfiguration(new CategoryConfig()); 
        }

    }
}
