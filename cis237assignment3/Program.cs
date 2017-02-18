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

            

            while (running)
            {
                ui.PrintMenu();
                int userInput = ui.GetUserInput();
                switch (userInput)
                {
                    case 1:
                        // Add droid
                        ui.PrintDroidModels();
                        string droidModel = ui.GetUserInputString();
                        while (droidModel.ToUpper() != "PROTOCOL" || droidModel.ToUpper() != "UTILITY" || droidModel.ToUpper() != "JANITOR" || droidModel.ToUpper() != "ASTROMECH")
                        {
                            ui.PrintDroidModels();
                            droidModel= ui.GetUserInputString();
                        }
                        

                        ui.PrintDroidMaterials();
                        string droidMaterial = ui.GetUserInputString();

                        ui.Output("Enter a color:");
                        string droidColor = ui.GetUserInputString();
                        break;
                    case 2:
                        // List droids
                        break;
                    default:
                        // Exit program
                        running = false;
                        break;
                }
            }

        }
    }
}
