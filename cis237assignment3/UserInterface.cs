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
            int result;
            while(!int.TryParse(Console.ReadLine(), out result))
            {
                PrintInvalidSelectionMessage();
            }

            return result;
        }

        public string GetUserInputString()
        {
            return Console.ReadLine();

        }

        public void PrintDroidModels()
        {
            ClearScreen();
            Output("Enter the name of a droid model from this list:");
            Output("Protocol");
            Output("Utility");
            Output("Janitor");
            Output("Astromech");
        }

        public void PrintDroidMaterials()
        {
            ClearScreen();
            Output("Enter the type of material from this list:");
            Output("Titanium");
            Output("Gold");
            Output("Steel");
        }

        public void GetInfoForUtilityDroid(ref bool hasToolbox, ref bool hasComputerConnection, ref bool hasArm)
        {
            ClearScreen();
            Output("Does the droid have a toolbox? TRUE:FALSE");
            hasComputerConnection = GetTrueFalseResponse();

            ClearScreen();
            Output("Does the droid have a computer connection? TRUE:FALSE");
            hasComputerConnection = GetTrueFalseResponse();

            ClearScreen();
            Output("Does the droid have arms? TRUE:FALSE");
            hasArm = GetTrueFalseResponse();
        }

        public void GetInfoForDroid(ref string droidModel, ref string droidMaterial, ref string droidColor)
        {
            PrintDroidModels();
            droidModel = GetUserInputString();
            while (droidModel.ToUpper() != "PROTOCOL" && droidModel.ToUpper() != "UTILITY" && droidModel.ToUpper() != "JANITOR" && droidModel.ToUpper() != "ASTROMECH")
            {
                PrintInvalidSelectionMessage();

                PrintDroidModels();
                droidModel = GetUserInputString();
            }


            PrintDroidMaterials();
            droidMaterial = GetUserInputString();
            while (droidMaterial.ToUpper() != "TITANIUM" && droidMaterial.ToUpper() != "GOLD" && droidMaterial.ToUpper() != "STEEL")
            {
                PrintInvalidSelectionMessage();

                PrintDroidMaterials();
                droidMaterial = GetUserInputString();
            }

            ClearScreen();
            Output("Enter a color:");
            droidColor = GetUserInputString();
        }

        public void GetInfoForProtocolDroid(ref int numberLanguages)
        {
            ClearScreen();
            Output("Enter # of languages:");
            numberLanguages = GetUserInput();
        }

        public void GetInfoForJanitorDroid(ref bool hasTrashCompactor, ref bool hasVacuum)
        {
            ClearScreen();
            Output("Does the droid have a trash compactor? TRUE:FALSE");
            hasTrashCompactor = GetTrueFalseResponse();

            ClearScreen();
            Output("Does the droid have a vacuum? TRUE:FALSE");
            hasVacuum = GetTrueFalseResponse();
        }

        public void GetInfoForAstromechDroid(ref bool hasFireExtinquisher, ref int numberShips)
        {
            ClearScreen();
            Output("Does the droid have a fire extinquisher? TRUE:FALSE");
            hasFireExtinquisher = GetTrueFalseResponse();

            ClearScreen();
            Output("Enter # of ships: ");
            numberShips = GetUserInput();
        }

        public bool GetTrueFalseResponse()
        {
            string response = GetUserInputString();
            while (response.ToUpper() != "TRUE" && response.ToUpper() != "FALSE")
            {
                PrintInvalidSelectionMessage();
                response = GetUserInputString();
            }

            if (response.ToUpper() == "TRUE")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PrintMenu()
        {
            ClearScreen();
            Output("1 - Add Droid");
            Output("2 - List Droids");
            Output("3 - Exit");
        }

        public void PrintSuccessfulAddDroidMessage()
        {
            Output("Droid was added successfully... Press Enter to continue...");
            WaitForInput();
        }

        public void PrintInvalidSelectionMessage()
        {
            Output("Invalid selection... Press enter to continue...");
            WaitForInput();
        }

        public void Output(string output)
        {
            Console.WriteLine(output);
        }

        public void ClearScreen()
        {
            Console.Clear();
        }

        public void WaitForInput()
        {
            Console.ReadLine();
        }
    }
}
