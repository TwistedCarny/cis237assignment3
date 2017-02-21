// Westin Curtis - CIS 237 - 1/21/2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UserInterface
    {

        // Get input from the user in the form of an int
        public int GetUserInput(string message)
        {
            Output(message);
            int result;
            while(!int.TryParse(Console.ReadLine(), out result)) // try to get input from user until they enter a number
            {
                PrintInvalidSelectionMessage();
                ClearScreen();
                Output(message);
            }

            return result;
        }

        // Get input from user in the form of a string
        public string GetUserInputString()
        {
            return Console.ReadLine();

        }

        // Output list of droids to choose from
        public void PrintDroidModels() 
        {
            ClearScreen();
            Output("Enter the name of a droid model from this list:");
            Output("Protocol");
            Output("Utility");
            Output("Janitor");
            Output("Astromech");
        }

        // Output list of droid materials
        public void PrintDroidMaterials()
        {
            ClearScreen();
            Output("Enter the type of material from this list:");
            Output("Titanium");
            Output("Gold");
            Output("Steel");
        }

        // Get the info related to the utility droid
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

        // Get the info related to the base droid that every droid inherits from
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

        // Get info related to the protocol droid
        public void GetInfoForProtocolDroid(ref int numberLanguages)
        {
            ClearScreen();
            string message = "Enter # of languages:";
            numberLanguages = GetUserInput(message);
        }

        // Get info related to the janitor droid
        public void GetInfoForJanitorDroid(ref bool hasTrashCompactor, ref bool hasVacuum)
        {
            ClearScreen();
            string message = "Does the droid have a trash compactor? TRUE:FALSE";
            hasTrashCompactor = GetTrueFalseResponse(message);

            ClearScreen();
            message = "Does the droid have a vacuum? TRUE:FALSE";
            hasVacuum = GetTrueFalseResponse(message);
        }

        // Get info related to the astromech droid
        public void GetInfoForAstromechDroid(ref bool hasFireExtinquisher, ref int numberShips)
        {
            ClearScreen();
            string message = "Does the droid have a fire extinquisher? TRUE:FALSE";
            hasFireExtinquisher = GetTrueFalseResponse(message);

            ClearScreen();
            message = "Enter # of ships: ";
            numberShips = GetUserInput(message);
        }

        // Get a response from the user in the form of a TRUE or FALSE
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

        // Returns a string that contains the main menu of the program
        public string GetPrintMainMenu()
        {
            return "1 - Add Droid" + Environment.NewLine +
                   "2 - List Droids" + Environment.NewLine +
                   "3 - Exit";
        }

        // Print message letting the user know that a droid was added sucessfully
        public void PrintSuccessfulAddDroidMessage()
        {
            ClearScreen();
            Output("Droid was added successfully... Press Enter to continue...");
            WaitForInput();
        }

        // Print message telling the user that they didn't make a valid selection 
        public void PrintInvalidSelectionMessage()
        {
            ClearScreen();
            Output("Invalid selection... Press enter to continue...");
            WaitForInput();
        }

        // Output text to the console
        public void Output(string output)
        {
            Console.WriteLine(output);
        }

        // Clear the console
        public void ClearScreen()
        {
            Console.Clear();
        }

        // Wait for input from user... used for waiting until the user presses enter.
        public void WaitForInput()
        {
            Console.ReadLine();
        }
    }
}
