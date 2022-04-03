using System.Collections.Generic;
using Xplosive.Models;
using Xplosive.Viewmodels;

namespace Xplosive.Adaptors
{
    public class FoodAdaptor
    {
        public Food GetFoodModel(FoodViewModel viewModel, DailyNutrition dailyNutrition)
        {
            var result = new Food()
            {
                Carbohydrates = viewModel.Carbohydrates,
                TimeOfDay = viewModel.TimeOfDay,
                Sodium = viewModel.Sodium,
                CarbohydratesSugar = viewModel.CarbohydratesSugar,
                Energy = viewModel.Energy,
                FatSaturated = viewModel.FatSaturated,
                Fat = viewModel.Fat,
                Fibres = viewModel.Fibres,
                Name = viewModel.Name,
                Protein = viewModel.Protein,
                DailyNutrition = dailyNutrition,
                DailyNutritionId= dailyNutrition.Id,
            };
            return result;
        }

        public List<FoodViewModel> GetFoodVms(List<Food> foods)
        {
            var foodVms = new List<FoodViewModel>();

            foreach (var food in foods)
            {
                var foodVm = new FoodViewModel()
                {
                    Carbohydrates = food.Carbohydrates,
                    TimeOfDay = food.TimeOfDay,
                    Sodium = food.Sodium,
                    CarbohydratesSugar = food.CarbohydratesSugar,
                    Energy = food.Energy,
                    FatSaturated = food.FatSaturated,
                    Fat = food.Fat,
                    Fibres = food.Fibres,
                    Name = food.Name,
                    Protein = food.Protein,
                };

                foodVms.Add(foodVm);
            }

            return foodVms;
        }
    }
}
