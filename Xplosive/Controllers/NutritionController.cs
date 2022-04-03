using Microsoft.AspNetCore.Mvc;
using Xplosive.Viewmodels;

namespace Xplosive.Controllers
{
    public class NutritionController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Add(FoodViewModel viewModel)
        {
            return this.View();
        }
    }
}
