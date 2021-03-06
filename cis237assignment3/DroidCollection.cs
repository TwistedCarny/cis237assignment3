﻿// Westin Curtis - CIS 237 - 1/21/2017

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

        // Add Protocol droid to the array
        public void Add(string model, string material, string color, int numberLanguages)
        {
            int index = SearchForEmptyIndex();
            if(index != -1)
            {
                droids[index] = new ProtocolDroid(model, material, color, numberLanguages);
            }
            
        }

        // Add utility droid to the array
        public void Add(string model, string material, string color, bool hasToolbox, bool hasComputerConnection, bool hasArm)
        {
            int index = SearchForEmptyIndex();
            if (index != -1)
            {
                droids[index] = new UtilityDroid(model, material, color, hasToolbox, hasComputerConnection, hasArm);
            }

        }

        // Add Janitor droid to the array
        public void Add(string model, string material, string color, bool hasToolbox, bool hasComputerConnection, bool hasArm, bool hasTrashCompactor, bool hasVacuum)
        {
            int index = SearchForEmptyIndex();
            if (index != -1)
            {
                droids[index] = new JanitorDroid(model, material, color, hasToolbox, hasComputerConnection, hasArm, hasTrashCompactor, hasVacuum);
            }
        }

        // Add Astromech droid to the array
        public void Add(string model, string material, string color, bool hasToolbox, bool hasComputerConnection, bool hasArm, bool hasFireExtinquisher, int numberShips)
        {
            int index = SearchForEmptyIndex();
            if (index != -1)
            {
                droids[index] = new AstromechDroid(model, material, color, hasToolbox, hasComputerConnection, hasArm, hasFireExtinquisher, numberShips);
            }
        }

        // Build a string to output to the user containing all of the droids in the droid array
        public string GetPrintString()
        {
            string output = string.Empty;

            foreach (IDroid droid in droids)
            {
                if (droid != null)
                {
                    droid.CalculateTotalCost();

                    output += "---------------------------" + 
                        Environment.NewLine +
                        droid.ToString() + 
                        Environment.NewLine +
                         "Total Cost: " +droid.TotalCost.ToString("C") +
                        Environment.NewLine +
                        "---------------------------";
                }
            }
            if(output == string.Empty)
            {
                output = "No droids found in list...";
            }

            return output;
        }

        // Search for empty index in array
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
