using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Program
    {
        private static UserInterface ui;
        static void Main(string[] args)
        {
            bool running = true;

            ui = new UserInterface();

            DroidCollection droidCollection = new DroidCollection(20);

            while (running)
            {
                ui.PrintMenu();
                int userInput = ui.GetUserInput();
                switch (userInput)
                {
                    case 1:
                        AddDroidMenuOption(droidCollection);
                        break;
                    case 2:
                        // List droids
                        ui.Output(droidCollection.GetPrintString());
                        break;
                    case 3:
                        // Exit program
                        running = false;
                        break;
                }
            }

        }

        private static void AddDroidMenuOption(DroidCollection droids)
        {
            // Add droid
            string droidModel = string.Empty;

            string droidMaterial = string.Empty;

            string droidColor = string.Empty;

            bool hasToolbox = false;
            bool hasComputerConnection = false;
            bool hasArm = false;

            ui.GetInfoForDroid(ref droidModel, ref droidMaterial, ref droidColor); 


            if (droidModel.ToUpper() == "PROTOCOL")
            {
                int numberLanguages = 0;

                ui.GetInfoForProtocolDroid(ref numberLanguages);

                droids.Add(droidModel, droidMaterial, droidColor, numberLanguages);
            }
            else if(droidModel.ToUpper() == "UTILITY")
            {
                
                ui.GetInfoForUtilityDroid(ref hasToolbox, ref hasComputerConnection, ref hasArm);

                droids.Add(droidModel, droidMaterial, droidColor, hasToolbox, hasComputerConnection, hasArm);
            }
            else if(droidModel.ToUpper() == "JANITOR")
            {
                ui.GetInfoForUtilityDroid(ref hasToolbox, ref hasComputerConnection, ref hasArm);

                bool hasTrashcompactor = false;
                bool hasVacuum = false;

                ui.GetInfoForJanitorDroid(ref hasTrashcompactor, ref hasVacuum);

                droids.Add(droidModel, droidMaterial, droidColor, hasToolbox, hasComputerConnection, hasArm, hasTrashcompactor, hasVacuum);
            }
            else if(droidModel.ToUpper() == "ASTROMECH")
            {
                ui.GetInfoForUtilityDroid(ref hasToolbox, ref hasComputerConnection, ref hasArm);

                bool hasFireExtinquisher = false;
                int numberShips = 0;

                ui.GetInfoForAstromechDroid(ref hasFireExtinquisher, ref numberShips);

                droids.Add(droidModel, droidMaterial, droidColor, hasToolbox, hasComputerConnection, hasArm, hasFireExtinquisher, numberShips);
            }
            
        }
    }
}
