using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UtilityDroid : Droid
    {
        private bool _hasToolbox;
        private bool _hasComputerConnection;
        private bool _hasArm;

        public UtilityDroid(string model, string material, string color, bool toolbox, bool computerConnection, bool arm) : base(model, material, color)
        {
            _hasToolbox = toolbox;
            _hasComputerConnection = computerConnection;
            _hasArm = arm;
        }

        public override void CalculateTotalCost()
        {
            base.CalculateTotalCost();
            if (_hasToolbox)
            {
                TotalCost += 10;
            }

            if (_hasComputerConnection)
            {
                TotalCost += 50;
            }

            if (_hasArm)
            {
                TotalCost += 25;
            }
        }

        public override string ToString()
        {
            return base.ToString() + " - " + "Has toolbox: " + _hasToolbox + " - " + "Has computer connection: " + _hasComputerConnection + " - " + "Has arm: " + _hasArm;
        }
    }
}
