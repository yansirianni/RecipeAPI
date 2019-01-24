using Microsoft.AspNetCore.Mvc;
using ReceitasAPI.Models;
using RecipeAPI.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RecipeAPI.Controllers
{
    [Route("Recipe")]
    public class RecipeController : Controller
    {

        public RecipeController()
        {

        }

        [HttpGet]
        [Route("GetRecipeByName")]
        public List<Recipe> GetRecipeByName(string name)
        {
            try
            {
                var RecipeListWithName = new RecipeManager().FindRecipeByName(name);
                return RecipeListWithName;

            }
            catch (Exception ex)
            {
                return null;
            }

        }

        [HttpGet]
        [Route("GetRecipeByIngredient")]
        public List<Recipe> GetRecipeByIngredient(string ingredient)
        {
            try
            {
                var RecipeListWithIngredient = new RecipeManager().FindRecipeByIngredient(ingredient);
                return RecipeListWithIngredient;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpGet]
        [Route("GetAllRecipes")]
        public List<Recipe> GetAllRecipes()
        {
            try
            {
                var AllRecipes = new RecipeManager().ReturnAllRecipes();
                return AllRecipes;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
