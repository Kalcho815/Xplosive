using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Xplosive.Models
{
    [Table("DAILY_INFOS")]
    public class DailyInfo
    {
        public DailyInfo()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Column("ID")]
        [Required]
        [Key]
        public string Id { get; set; }

        [Column("WORKOUT_ID")]
        [ForeignKey("WORKOUT")]
        public string WorkoutId { get; set; }

        public DailyWorkout Workout { get; set; }

        [Column("NUTRITION_ID")]
        [ForeignKey("DAILY_NUTRITION")]
        public string NutritionId { get; set; }

        public DailyNutrition Nutrition { get; set; }

        [Column("WEIGHT")]
        public double Weight { get; set; }

        [Column("DATE")]
        public DateTime Date { get; set; }


        [Column("USER_ID")]
        [ForeignKey("USER")]
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
