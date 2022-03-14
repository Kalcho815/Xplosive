using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Xplosive.Models
{
    public class Set
    {
        public Set()
        {

        }

        [Required]
        [Column("ID")]
        public string Id { get; set; }

        [Column("EXERCISE_ID")]
        public int ExerciseId { get; set; }

        [Column("EXERCISE_NAME")]
        public string ExerciseName { get; set; }

        [Column("NUMBER")]
        public int Number { get; set; }

        [Column("REP_COUNT")]
        public int RepCount { get; set; }

        [Column("WEIGHT")]
        public double Weight { get; set; }

        [Column("DAILY_WORKOUT_ID")]
        [ForeignKey("DAILY_WORKOUT")]
        public string DailyWorkoutId { get; set; }

        public DailyWorkout DailyWorkout { get; set; }
    }
}
