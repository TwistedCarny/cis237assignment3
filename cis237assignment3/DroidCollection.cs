using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class DroidCollection
    {
        private IDroid[] droids;

        public DroidCollection(int size)
        {
            droids = new IDroid[size];
        }

        // Add Protocol droid
        public void Add(string model, string material, string color, int numberLanguages)
        {
            int index = SearchForEmptyIndex();
            if(index != -1)
            {
                droids[index] = new ProtocolDroid(model, material, color, numberLanguages);
            }
            
        }

        // Add utility droid
        public void Add(string model, string material, string color, bool hasToolbox, bool hasComputerConnection, bool hasArm)
        {
            int index = SearchForEmptyIndex();
            if (index != -1)
            {
                droids[index] = new UtilityDroid(model, material, color, hasToolbox, hasComputerConnection, hasArm);
            }

        }

        // Add Janitor droid
        public void Add(string model, string material, string color, bool hasToolbox, bool hasComputerConnection, bool hasArm, bool hasTrashCompactor, bool hasVacuum)
        {
            int index = SearchForEmptyIndex();
            if (index != -1)
            {
                droids[index] = new JanitorDroid(model, material, color, hasToolbox, hasComputerConnection, hasArm, hasTrashCompactor, hasVacuum);
            }
        }

        public string GetPrintString()
        {
            string output = "";

            foreach (IDroid droid in droids)
            {
                if (droid != null)
                {
                    droid.CalculateTotalCost();
                    output += droid.ToString() + " - " + droid.TotalCost.ToString("C") + Environment.NewLine;
                }
            }
            return output;
        }

        private int SearchForEmptyIndex()
        {
            for (int i = 0; i < droids.Length; i++)
            {
                if (droids[i] == null)
                {
                    return i; // Found empty index
                }
            }

            return -1; // Did not find empty index
        }

    }
}
