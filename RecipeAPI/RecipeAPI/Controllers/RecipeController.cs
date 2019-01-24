using Microsoft.AspNetCore.Mvc;
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
        public async Task<ActionResult> GetRecipeByName(string name)
        {
            
        }

        [HttpGet]
        [Route("GetRecipeByingredient")]
        public async Task<ActionResult> GetRecipeByingredient(string ingredient)
        {

        }

    }
}
