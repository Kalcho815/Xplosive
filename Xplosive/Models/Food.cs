using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Xplosive.Models
{
    [Table("FOOD")]
    public class Food
    {
        public Food()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Required]
        [Column("ID")]
        [Key]
        public string Id { get; set; }

        [Required]
        [Column("NAME")]
        public string Name { get; set; }

        [Column("NUTRITIONAL_VALUE")]
        public string NutritionalValue { get; set; }

        [Column("TIME_OF_DAY")]
        public DateTime TimeOfDay { get; set; }

        [Column("ENERGY")]
        public double Energy { get; set; }

        [Column("PROTEIN")]
        public double Protein { get; set; }

        [Column("CARBOHYDRATES")]
        public double Carbohydrates { get; set; }

        [Column("CARBOHYDRATES_SUGAR")]
        public double CarbohydratesSugar { get; set; }

        [Column("FAT")]
        public double Fat { get; set; }

        [Column("FAT_SATURATED")]
        public double FatSaturated { get; set; }

        [Column("FIBRES")]
        public double Fibres { get; set; }

        [Column("SODIUM")]
        public double Sodium { get; set; }

        [Column("DAILY_NUTRITION_ID")]
        [ForeignKey("DAILY_NUTRITION")]
        public string DailyNutritionId { get; set; }

        public DailyNutrition DailyNutrition { get; set; }
    }
}
