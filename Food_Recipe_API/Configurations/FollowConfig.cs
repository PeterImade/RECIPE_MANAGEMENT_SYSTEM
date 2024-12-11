using Food_Recipe_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RECIPE_MANAGEMENT_SYSTEM.Configurations
{
    public class FollowConfig : IEntityTypeConfiguration<Follow>
    {
        public void Configure(EntityTypeBuilder<Follow> builder)
        {
            builder.ToTable("Followings");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasDefaultValueSql("NEWID()");
            
            builder.HasKey(f => new {f.FollowerId, f.FollowedUserId});

            builder
                .HasOne(x => x.Follower)
                .WithMany(x => x.Following)
                .HasForeignKey(x => x.FollowerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
            
            builder
                .HasOne(x => x.FollowedUser)
                .WithMany(x => x.Followers)
                .HasForeignKey(x => x.FollowedUserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
