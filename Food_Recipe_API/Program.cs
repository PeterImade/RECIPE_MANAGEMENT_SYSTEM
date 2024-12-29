

using Food_Recipe_API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RECIPE_MANAGEMENT_SYSTEM.Configurations.AutoMapper;
using RECIPE_MANAGEMENT_SYSTEM.Contracts;
using RECIPE_MANAGEMENT_SYSTEM.Data;
using RECIPE_MANAGEMENT_SYSTEM.Repository;

namespace Food_Recipe_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers(); 
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var connectionString = builder.Configuration.GetConnectionString("RecipeAPIDBConnection");
            builder.Services.AddDbContext<RecipeDBContext>(options => { options.UseSqlServer(connectionString); });


            builder.Services.AddAutoMapper(typeof(AutoMapperConfig));

            // Repositories and Unit of Work
            builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddScoped<IRecipeRepository, RecipeRepository>();
            builder.Services.AddScoped<IRatingRepository, RatingRespository>();
            builder.Services.AddScoped<INotificationRepository, NotificationRepository>();  
            builder.Services.AddScoped<ICommentRepository, CommentRepository>();
            builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

            //Identity configuration
            builder.Services.AddAuthentication();
           
            builder.Services.AddIdentity<User, IdentityRole>(o =>
            {
                o.Password.RequireDigit = true;
                o.Password.RequireLowercase = true;
                o.Password.RequireUppercase = true;
                o.Password.RequireNonAlphanumeric = true;
                o.User.RequireUniqueEmail = true;
            }).AddEntityFrameworkStores<RecipeDBContext>()
              .AddDefaultTokenProviders(); 



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthentication();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
