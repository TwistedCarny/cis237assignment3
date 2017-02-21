// Westin Curtis - CIS 237 - 1/21/2017

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

        private const decimal TOOLBOX_COST = 10m;
        private const decimal COMPUTER_CONNECTION_COST = 50m;
        private const decimal ARM_COST = 25;

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
                TotalCost += TOOLBOX_COST;
            }

            if (_hasComputerConnection)
            {
                TotalCost += COMPUTER_CONNECTION_COST;
            }

            if (_hasArm)
            {
                TotalCost += ARM_COST;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "Has toolbox: " + _hasToolbox + Environment.NewLine + "Has computer connection: " + _hasComputerConnection + Environment.NewLine + "Has arm: " + _hasArm + Environment.NewLine;
        }
    }
}
