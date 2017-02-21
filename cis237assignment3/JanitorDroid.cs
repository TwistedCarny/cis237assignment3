// Westin Curtis - CIS 237 - 1/21/2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class JanitorDroid : UtilityDroid
    {
        private bool _hasTrashCompactor;
        private bool _hasVacuum;

        private const decimal TRASH_COMPACTOR_COST = 30m;
        private const decimal VACUUM_COST = 20m;

        public JanitorDroid(string model, string material, string color, bool toolbox, bool computerConnection, bool arm, bool trashCompactor, bool vacuum) : base(model, material, color, toolbox, computerConnection, arm)
        {
            _hasTrashCompactor = trashCompactor;
            _hasVacuum = vacuum;
        }

        public override void CalculateTotalCost()
        {
            base.CalculateTotalCost();
            if (_hasTrashCompactor)
            {
                TotalCost += TRASH_COMPACTOR_COST;
            }

            if (_hasVacuum)
            {
                TotalCost += VACUUM_COST;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "Has trash compactor: " + _hasTrashCompactor + Environment.NewLine + "Has vacuum: " + _hasVacuum;
        }
    }
}
