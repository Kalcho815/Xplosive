using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Xplosive.Models
{
    public class Set
    {
        public string Id { get; set; }

        public int ExerciseId { get; set; }

        public string ExerciseName { get; set; }

        public int Number { get; set; }

        public int RepCount { get; set; }

        public double Weight { get; set; }
    }
}
