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
        List<Recipe> RecipesData = new RecipesDataGetter().LoadFileRecipeList();

        public RecipeManager()
        {

        }

        public List<Recipe> FindRecipeByName(string name)
        {
            List<Recipe> response = new List<Recipe>();

            foreach (Recipe recipe in RecipesData)
            {
                if (name.Equals(recipe.Nome))
                {
                    response.Add(recipe);
                }
            }
            return response;
        }

        public List<Recipe> FindRecipeByIngredient(string ingredient)
        {
            List<Recipe> response = new List<Recipe>();

            foreach (Recipe recipe in RecipesData)
            {
                foreach (var secao in recipe.Secao)
                {
                    if(secao.Nome.Equals(" Ingredientes"))
                    {
                        foreach (string ingrediente in secao.Conteudo)
                        {
                            if(ingrediente.Equals(ingredient))
                            {
                                response.Add(recipe);
                            }
                        }
                    }                    
                }

            }

            return RecipesData;
        }

        public List<Recipe> ReturnAllRecipes()
        {
            return RecipesData;
        }
    }
}
