using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Xplosive.Models
{
    public class Food
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string NutritionalValue { get; set; }

        public DateTime TimeOfDay { get; set; }

        public double Energy { get; set; }

        public double Protein { get; set; }

        public double Carbohydrates { get; set; }

        public double CarbohydratesSugar { get; set; }

        public double Fat { get; set; }

        public double FatSaturated { get; set; }

        public double Fibres { get; set; }

        public double Sodium { get; set; }
    }
}
