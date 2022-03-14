using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Xplosive.Models
{
    public class DailyInfo
    {
        [Column("ID")]
        [Required]
        public string Id { get; set; }

        [Column("WORKOUT_ID")]
        [ForeignKey("WORKOUT")]
        public string WorkoutId { get; set; }

        public DailyWorkout Workout { get; set; }

        [Column("NUTRITION_ID")]
        [ForeignKey("NUTRITION")]
        public string NutritionId { get; set; }

        public DailyNutrition Nutrition { get; set; }

        [Column("WEIGHT")]
        public double Weight { get; set; }
    }
}
