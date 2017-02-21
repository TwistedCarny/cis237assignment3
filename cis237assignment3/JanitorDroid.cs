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
                TotalCost += 30m;
            }

            if (_hasVacuum)
            {
                TotalCost += 20m;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "Has trash compactor: " + _hasTrashCompactor + Environment.NewLine + "Has vacuum: " + _hasVacuum;
        }
    }
}
