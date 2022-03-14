﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Xplosive.Models
{
    public class DailyWorkout
    {
        public DailyWorkout()
        {
            this.Sets = new List<Set>();
        }

        [Column("ID")]
        [Required]
        public string Id { get; set; }

        [Column("DATE")]
        public DateTime Date { get; set; }

        [Column("SETS")]
        public List<Set> Sets { get; set; }

        [Column("LOG")]
        public string Log { get; set; }

        [Column("DAILY_INFO_ID")]
        [ForeignKey("DAILY_INFO")]
        public string DailyInfoId { get; set; }

        public DailyInfo DailyInfo { get; set; }
    }
}
