using Food_Recipe_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RECIPE_MANAGEMENT_SYSTEM.Configurations
{
    public class CommentConfig : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comments");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasDefaultValueSql("NEWID()");

            //In Entity Framework, when configuring relationships using the Fluent API, the configuration is typically done in the entity that holds the foreign key
            builder
                .HasOne(x => x.User)
                .WithMany(x => x.Comments)
                .HasForeignKey(x => x.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
            
            builder
                .HasOne(x => x.Recipe)
                .WithMany(x => x.Comments)
                .HasForeignKey(x => x.RecipeId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
