using ReceitasAPI.Models;
using System.Collections.Generic;

namespace RecipeAPI.Interfaces
{
    public interface IRecipesDataGetter
    {
        List<Recipe> LoadFileRecipeList();
        List<Recipe> RemovesRepeatedRecipes(List<Recipe> recipes);
    }
}