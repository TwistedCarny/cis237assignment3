using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UserInterface
    {
        public int GetUserInput()
        {
            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch
            {
                PrintInvalidSelectionMessage();
                return -1;
            }

        }

        public string GetUserInputString()
        {
            return Console.ReadLine();

        }

        public void PrintDroidModels()
        {
            Output("Enter the name of a droid model from this list:");
            Output("Protocol");
            Output("Utility");
            Output("Janitor");
            Output("Astromech");
        }

        public void PrintDroidMaterials()
        {
            Output("Enter the type of material from this list:");
            Output("Titanium");
            Output("Gold");
            Output("Steel");
        }

        public void PrintMenu()
        {
            Output("1 - Add Droid");
            Output("2 - List Droids");
            Output("3 - Exit");
        }

        public void PrintInvalidSelectionMessage()
        {
            Output("Invalid selection... Please select a vaild item from the menu.");
        }

        public void Output(string output)
        {
            Console.WriteLine(output);
        }

        public void ClearScreen()
        {
            Console.Clear();
        }
    }
}
