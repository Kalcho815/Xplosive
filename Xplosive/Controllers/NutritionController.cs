using Microsoft.AspNetCore.Mvc;
using System;
using Xplosive.Services;
using Xplosive.Viewmodels;

namespace Xplosive.Controllers
{
    public class NutritionController : Controller
    {
        private readonly FoodService foodService;
        private readonly NutritionService nutritionService;

        public NutritionController(FoodService foodService, NutritionService nutritionService)
        {
            this.foodService = foodService;
            this.nutritionService = nutritionService;
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

        [HttpGet]
        public IActionResult All(DateTime date)
        {
            var viewModels = nutritionService.GetNutritionVm(date);

            return this.View(viewModels);
        }

    }
}
