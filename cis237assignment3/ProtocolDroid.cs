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

        public ProtocolDroid(string material, string model, string color, int numberLanguages) : base(material, model, color)
        {
            _numberLanguages = numberLanguages;
        }

        public override void CalculateTotalCost()
        {
            TotalCost += _numberLanguages * COST_PER_LANGUAGE;
        }

        public override string ToString()
        {
            return base.ToString() + " - # Languages: " + _numberLanguages.ToString();
        }

    }
}
