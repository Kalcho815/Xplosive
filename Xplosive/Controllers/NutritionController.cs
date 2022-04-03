using Microsoft.AspNetCore.Mvc;
using Xplosive.Services;
using Xplosive.Viewmodels;

namespace Xplosive.Controllers
{
    public class NutritionController : Controller
    {
        private readonly FoodService foodService;

        public NutritionController(FoodService foodService)
        {
            this.foodService = foodService;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Add(FoodViewModel viewModel)
        {
            foodService.AddFood(viewModel);

            return this.View();
        }
    }
}
