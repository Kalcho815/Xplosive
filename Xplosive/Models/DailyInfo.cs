using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Xplosive.Models
{
    public class DailyInfo
    {
        public string Id { get; set; }

        public DailyWorkout Workout { get; set; }

        public DailyNutrition Nutrition { get; set; }

        public double Weight { get; set; }
    }
}
