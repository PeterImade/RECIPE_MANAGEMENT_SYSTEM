using Food_Recipe_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RECIPE_MANAGEMENT_SYSTEM.Configurations
{
    public class RatingConfig : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder.ToTable("Ratings");
            builder.HasKey(x=>x.Id); 

            builder
                .HasOne(x => x.User)
                .WithMany(x => x.Ratings)
                .HasForeignKey(x => x.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
            
            builder
                .HasOne(x => x.Recipe)
                .WithMany(x => x.Ratings)
                .HasForeignKey(x => x.RecipeId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
