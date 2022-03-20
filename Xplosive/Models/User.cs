using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Xplosive.Models
{
    [Table("USERS")]
    public class User : IdentityUser
    {
        public User()
        {
            this.DailyInfos = new List<DailyInfo>();
            this.Id = Guid.NewGuid().ToString();
        }

        [Column("ID")]
        [Required]
        [Key]
        public string Id { get; set; }

        [Column("DATE_OF_BIRTH")]
        public DateTime DateOfBirth { get; set; }

        [Column("FULL_NAME")]
        public string FullName { get; set; }

        [Column("SEX")]
        public string Sex { get; set; }

        [Column("WEIGHT")]
        public double Weight { get; set; }

        [Column("HEIGHT")]
        public double Height { get; set; }

        [Column("ACTIVITY_LEVEL")]
        public int ActivityLevel { get; set; }

        [Column("WEIGHT_GOAL")]
        public double WeightGoal { get; set; }

        [Column("CALORIC_GOAL")]
        public int CaloricGoal { get; set; }

        public List<DailyInfo> DailyInfos { get; set; }
    }
}
