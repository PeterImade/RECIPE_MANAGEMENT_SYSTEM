using Food_Recipe_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RECIPE_MANAGEMENT_SYSTEM.Configurations
{
    public class RecipeConfig : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            builder.ToTable("Recipes");
            builder.HasKey( x => x.Id ); 
            builder.Property(x => x.Id).HasDefaultValueSql("NEWID()");

            builder.HasIndex( x => x.Id ).IsUnique();

            builder
                .HasOne(x => x.User)
                .WithMany(x => x.Recipes)
                .HasForeignKey(x => x.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(x => x.Category)
                .WithMany(x => x.Recipes)
                .HasForeignKey(x => x.CategoryId)
                .IsRequired()   
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}