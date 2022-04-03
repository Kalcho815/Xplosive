using System;
using Xplosive.Adaptors;
using Xplosive.Data;
using Xplosive.Viewmodels;

namespace Xplosive.Services
{
    public class FoodService
    {
        private readonly XplosiveDbContext dbcontext;
        private readonly FoodAdaptor adaptor;
        private readonly NutritionService nutritionService;

        public FoodService(XplosiveDbContext dbcontext, FoodAdaptor adaptor, NutritionService nutritionService)
        {
            this.dbcontext = dbcontext;
            this.adaptor = adaptor;
            this.nutritionService = nutritionService;
        }

        public void AddFood(FoodViewModel viewModel)
        {
            var dailyNutrition = nutritionService.GetDailyNutrition(DateTime.Now);

            var food = this.adaptor.GetFoodModel(viewModel, dailyNutrition);

            dbcontext.Foods.Add(food);
            dbcontext.SaveChanges();
        }
    }
}
