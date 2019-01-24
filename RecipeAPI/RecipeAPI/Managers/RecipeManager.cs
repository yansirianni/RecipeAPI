using ReceitasAPI.Models;
using RecipeAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeAPI.Managers
{
    public class RecipeManager : IRecipeManager
    {
        List<Recipe> RecipesData;

        public RecipeManager()
        {             

        }

        public List<Recipe> FindRecipeByName(string name)
        {
            
        }

        public List<Recipe> FindRecipeByIngredient(string ingredient)
        {

        }
    }
}
