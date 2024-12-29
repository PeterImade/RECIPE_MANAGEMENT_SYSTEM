using AutoMapper;
using Food_Recipe_API.Models;
using RECIPE_MANAGEMENT_SYSTEM.Contracts;
using RECIPE_MANAGEMENT_SYSTEM.DTOs.RecipeDTOs;
using RECIPE_MANAGEMENT_SYSTEM.Services.Contracts;

namespace RECIPE_MANAGEMENT_SYSTEM.Services
{
    public class RecipeService: IRecipeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RecipeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        public async Task<RecipeDto> CreateRecipeAsync(RecipeForCreationDto recipeForCreationDto)
        {
            var recipeEntity = _mapper.Map<Recipe>(recipeForCreationDto);
            _unitOfWork.Recipes.CreateRecipeAsync(recipeEntity);
            await _unitOfWork.SaveAsync();
            var recipeToReturn = _mapper.Map<RecipeDto>(recipeEntity);
            return recipeToReturn;
        }

        public async Task DeleteRecipeAsync(int recipeId, bool trackChanges)
        {
            var recipe = await _unitOfWork.Recipes.GetRecipeAsync(recipeId, trackChanges);
            if (recipe is null)
            {
                // throw exception here.
            }
            _unitOfWork.Recipes.DeleteRecipeAsync(recipe);
            await _unitOfWork.SaveAsync();
        }

        public async Task<IEnumerable<RecipeDto>> GetAllRecipesAsync(bool trackChanges)
        {
            var recipes = await _unitOfWork.Recipes.GetAllRecipesAsync(trackChanges);
            var recipesDto = _mapper.Map<IEnumerable<RecipeDto>>(recipes);
            return recipesDto;
        }

        public async Task<RecipeDto> GetRecipeAsync(int recipeId, bool trackChanges)
        {
            var recipe = await _unitOfWork.Recipes.GetRecipeAsync(recipeId, trackChanges);
            if (recipe is null)
            {
                // throw exception here
            }
            var recipeDto = _mapper.Map<RecipeDto>(recipe);
            return recipeDto;
        }

        public async Task<RecipeDto> UpdateRecipeAsync(int recipeId, RecipeForUpdateDto recipeForUpdateDto, bool trackChanges)
        {
            var recipeEntity = await _unitOfWork.Recipes.GetRecipeAsync(recipeId, trackChanges);
            if (recipeEntity is null)
            {
                // throw exception here
            }
             _unitOfWork.Recipes.UpdateRecipeAsync(recipeEntity);
            await _unitOfWork.SaveAsync();
            var recipeToReturn = _mapper.Map<RecipeDto>(recipeEntity);
            return recipeToReturn;
        }
    }
}
