using AutoMapper;
using Food_Recipe_API.Models;
using RECIPE_MANAGEMENT_SYSTEM.DTOs.RecipeDTOs;

namespace RECIPE_MANAGEMENT_SYSTEM.Configurations.AutoMapper
{
    public class AutoMapperConfig: Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RecipeDto, Recipe>().ReverseMap();
            CreateMap<RecipeForCreationDto, Recipe>().ReverseMap();
        }
    }
}
