using System;
using System.Collections.Generic;

namespace Xplosive.Viewmodels
{
    public class DailyNutritionViewModel
    {
        public string Id { get; set; }

        public DateTime Date { get; set; }

        public List<FoodViewModel> Foods { get; set; }

        public string Log { get; set; }
    }
}
