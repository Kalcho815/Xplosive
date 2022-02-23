using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Xplosive.Models
{
    public class DailyNutrition
    {
        public string Id { get; set; }

        public List<Food> Foods { get; set; }

        public DateTime Date { get; set; }

        public string Log { get; set; }
    }
}
