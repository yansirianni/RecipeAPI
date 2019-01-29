using Newtonsoft.Json;
using ReceitasAPI.Models;
using RecipeAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeAPI.Managers
{
    public class RecipesDataGetter : IRecipesDataGetter
    {

        public List<Recipe> LoadFileRecipeList()
        {
            List <Recipe> ListRecipes = new List<Recipe>();

            using (StreamReader r = new StreamReader("receitas.json"))
            {
                string json = r.ReadToEnd();
                ListRecipes = JsonConvert.DeserializeObject<List<Recipe>>(json);
            }

            return ListRecipes;
        }

        public List<Recipe> RemovesRepeatedRecipes(List<Recipe> recipes)
        {

            return recipes;
        }

    }
}
