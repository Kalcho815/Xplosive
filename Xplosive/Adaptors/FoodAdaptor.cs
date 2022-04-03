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
    }
}
