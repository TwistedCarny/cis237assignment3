// Westin Curtis - CIS 237 - 1/21/2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class AstromechDroid : UtilityDroid
    {
        private bool _hasFireExtinquisher;
        private int _numberShips;

        private const decimal COST_PER_SHIP = 25m;

        private const decimal FIRE_EXTINQUISHER_COST = 60m;

        public AstromechDroid(string model, string material, string color, bool toolbox, bool computerConnection, bool arm, bool fireExtinquisher, int numberShips) : base(model, material, color, toolbox, computerConnection, arm)
        {
            _hasFireExtinquisher = fireExtinquisher;
            _numberShips = numberShips;
        }

        public override void CalculateTotalCost()
        {
            base.CalculateTotalCost();
            if (_hasFireExtinquisher)
            {
                TotalCost += FIRE_EXTINQUISHER_COST;
            }
            TotalCost += _numberShips * COST_PER_SHIP;
        }

        public override string ToString()
        {
            return base.ToString() + "Has fire extinquisher: " + _hasFireExtinquisher + Environment.NewLine + "# Ships: " + _numberShips.ToString();
        }
    }
}
