using ReceitasAPI.Models;
using System.Collections.Generic;

namespace RecipeAPI.Interfaces
{
    public interface IRecipeManager
    {
        List<Recipe> FindRecipeByName(string name);
        List<Recipe> FindRecipeByIngredient(string ingredient);
        List<Recipe> ReturnAllRecipes();
    }
}