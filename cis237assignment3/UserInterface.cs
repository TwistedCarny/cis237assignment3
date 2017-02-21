using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UserInterface
    {
        public int GetUserInput(string message)
        {
            Output(message);
            int result;
            while(!int.TryParse(Console.ReadLine(), out result))
            {
                PrintInvalidSelectionMessage();
                ClearScreen();
                Output(message);
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
            string message = "Does the droid have a toolbox? TRUE:FALSE";
            hasComputerConnection = GetTrueFalseResponse(message);

            ClearScreen();
            message = "Does the droid have a computer connection? TRUE:FALSE";
            hasComputerConnection = GetTrueFalseResponse(message);

            ClearScreen();
            message = "Does the droid have arms? TRUE:FALSE";
            hasArm = GetTrueFalseResponse(message);
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
            string message = "Enter # of languages:";
            numberLanguages = GetUserInput(message);
        }

        public void GetInfoForJanitorDroid(ref bool hasTrashCompactor, ref bool hasVacuum)
        {
            ClearScreen();
            string message = "Does the droid have a trash compactor? TRUE:FALSE";
            hasTrashCompactor = GetTrueFalseResponse(message);

            ClearScreen();
            message = "Does the droid have a vacuum? TRUE:FALSE";
            hasVacuum = GetTrueFalseResponse(message);
        }

        public void GetInfoForAstromechDroid(ref bool hasFireExtinquisher, ref int numberShips)
        {
            ClearScreen();
            string message = "Does the droid have a fire extinquisher? TRUE:FALSE";
            hasFireExtinquisher = GetTrueFalseResponse(message);

            ClearScreen();
            message = "Enter # of ships: ";
            numberShips = GetUserInput(message);
        }

        public bool GetTrueFalseResponse(string message)
        {
            Output(message);
            string response = GetUserInputString();
            while (response.ToUpper() != "TRUE" && response.ToUpper() != "FALSE")
            {
                PrintInvalidSelectionMessage();
                ClearScreen();
                Output(message);
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

        public string GetPrintMainMenu()
        {
            return "1 - Add Droid" + Environment.NewLine +
                   "2 - List Droids" + Environment.NewLine +
                   "3 - Exit";
        }

        public void PrintSuccessfulAddDroidMessage()
        {
            ClearScreen();
            Output("Droid was added successfully... Press Enter to continue...");
            WaitForInput();
        }

        public void PrintInvalidSelectionMessage()
        {
            ClearScreen();
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
