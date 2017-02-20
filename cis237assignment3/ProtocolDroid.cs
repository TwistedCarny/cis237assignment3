using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class ProtocolDroid : Droid
    {
        private int _numberLanguages;

        private const decimal COST_PER_LANGUAGE = 20m;

        public ProtocolDroid(string model, string material, string color, int numberLanguages) : base(model, material, color)
        {
            _numberLanguages = numberLanguages;
        }

        public override void CalculateTotalCost()
        {
            base.CalculateTotalCost();
            TotalCost += _numberLanguages * COST_PER_LANGUAGE;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "# Languages: " + _numberLanguages.ToString();
        }

    }
}
