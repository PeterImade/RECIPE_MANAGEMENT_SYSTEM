using Food_Recipe_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RECIPE_MANAGEMENT_SYSTEM.Configurations
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasDefaultValueSql("NEWID()");

            builder.Property(x => x.Email).IsRequired().HasMaxLength(256);
            builder.Property(x => x.UserName).IsRequired().HasMaxLength(250);
            builder.Property(x => x.PasswordHash).IsRequired().HasMaxLength(250);

            builder.HasIndex(x => x.Email).IsUnique();
            builder.HasIndex(x => x.UserName).IsUnique();
        }
    }
}