// Westin Curtis - CIS 237 - 1/21/2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    // Interface that all droids implement
    interface IDroid
    {
        void CalculateTotalCost();

        decimal TotalCost { get; set; }

    }
}
