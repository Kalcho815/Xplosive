using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Xplosive.Models
{
    public class DailyWorkout
    {
        public string Id { get; set; }

        public DateTime Date { get; set; }

        public List<Set> Sets { get; set; }

        public string Log { get; set; }

    }
}
