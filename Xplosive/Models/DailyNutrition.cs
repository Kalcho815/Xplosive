using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Xplosive.Models
{
    [Table("DAILY_NUTRITIONS")]
    public class DailyNutrition
    {
        public DailyNutrition()
        {
            this.Foods = new List<Food>();
            this.Id = Guid.NewGuid().ToString();
        }

        [Column("ID")]
        [Required]
        [Key]
        public string Id { get; set; }

        [Column("FOODS")]
        public List<Food> Foods { get; set; }

        [Column("DATE")]
        public DateTime Date { get; set; }

        [Column("LOG")]
        public string Log { get; set; }

        [Column("DAILY_INFO_ID")]
        [ForeignKey("DAILY_INFO")]
        public string DailyInfoId { get; set; }

        public DailyInfo DailyInfo { get; set; }
    }
}
