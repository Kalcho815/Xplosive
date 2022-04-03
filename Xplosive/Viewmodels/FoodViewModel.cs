using System;
using Xplosive.Models;

namespace Xplosive.Viewmodels
{
    //protein=0.890&carbohydrates=14.000&carbohydratesSugar=11.780&fibres=0.000&energy=60&fat=0.000&fatSaturated=0.000&sodium=0.006&protein=0.833&carbohydrates=10.800&carbohydratesSugar=9.170&fibres=&energy=45&fat=0.000&fatSaturated=0.000&sodium=0.000&protein=0.400&carbohydrates=4.800&carbohydratesSugar=4.500&fibres=0.300&energy=23&fat=0.300&fatSaturated=0.068&sodium=0.003

    public class FoodViewModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string NutritionalValue { get; set; }

        public DateTime TimeOfDay { get; set; }

        public double Energy { get; set; }

        public double Protein { get; set; }

        public double Carbohydrates { get; set; }

        public double CarbohydratesSugar { get; set; }

        public double Fat { get; set; }

        public double FatSaturated { get; set; }

        public double Fibres { get; set; }

        public double Sodium { get; set; }

        public string DailyNutritionId { get; set; }

        public DailyNutrition DailyNutrition { get; set; }
    }
}
