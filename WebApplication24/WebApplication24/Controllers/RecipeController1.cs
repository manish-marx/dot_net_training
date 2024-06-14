using Microsoft.AspNetCore.Mvc;

namespace WebApplication24.Controllers
{
    public class RecipeController1 : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            VeiwData["Title"] = "Recipe";
            return View();
        }
        [HttpPost]
        public IActionResult Index(string recipe)
        {
            VeiwData["Title"] = "Recipe";
            VeiwData["RecipeName"] = recipeName;
            VeiwData["RecipeDescription"] = $"Description for {recipeName};
            return Veiw();
        }
    }
}
