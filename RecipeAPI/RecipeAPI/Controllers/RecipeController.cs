using Microsoft.AspNetCore.Mvc;
using ReceitasAPI.Models;
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

            }
            catch (Exception ex)
            {

                throw;
            }

        }

        [HttpGet]
        [Route("GetRecipeByingredient")]
        public List<Recipe> GetRecipeByingredient(string ingredient)
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpGet]
        [Route("GetAllRecipes")]
        public List<Recipe> GetAllRecipes()
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}
