using Food_Recipe_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RECIPE_MANAGEMENT_SYSTEM.Configurations
{
    public class FavoriteConfig : IEntityTypeConfiguration<Favorite>
    {
        public void Configure(EntityTypeBuilder<Favorite> builder)
        {
            builder.ToTable("Favorites"); 

            builder.HasKey(x => new {x.UserId, x.RecipeId});

            builder
                .HasOne(x => x.User)
                .WithMany(x => x.FavoriteRecipes)
                .HasForeignKey(x => x.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
            
            builder
                .HasOne(x => x.Recipe)
                .WithMany(x => x.FavoriteRecipes)
                .HasForeignKey(x => x.RecipeId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
