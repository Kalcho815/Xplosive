using System;
using System.Collections.Generic;

namespace Xplosive.Viewmodels
{
    public class DailyWorkoutViewModel
    {
        public string Id { get; set; }

        public DateTime Date { get; set; }

        public List<SetViewmodel> Sets { get; set; }

        public string Log { get; set; }
    }
}
