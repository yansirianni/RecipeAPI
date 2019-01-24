using ReceitasAPI.Models;
using RecipeAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeAPI.Managers
{
    public class RecipesDataGetter : IRecipesDataGetter
    {
        public List<Recipe> UploadFileRecipeList()
        {
            return new List<Recipe>();
        }

    }
}
