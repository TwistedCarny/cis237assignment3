using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UtilityDroid : Droid
    {
        public UtilityDroid(string material, string model, string color) : base(material, model, color)
        {
        }

        public override void CalculateTotalCost()
        {
            base.CalculateTotalCost();
        }
    }
}
