using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class AstromechDroid : UtilityDroid
    {
        public AstromechDroid(string model, string material, string color, bool toolbox, bool computerConnection, bool arm) : base(model, material, color, toolbox, computerConnection, arm)
        {
        }
    }
}
