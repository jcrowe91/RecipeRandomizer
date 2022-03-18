using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeRandomizer
{
    class ConsoleLogging
    {
        public static void PassMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static void ClearConsole()
        {
            Console.Clear();
        }

        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the RECIPE RANDOMIZER!");
            Console.WriteLine("-------------------------");
        }

        public static void InvalidInput()
        {
            Console.WriteLine("Invalid Input. Please make an appropriate selection");
        }

        public static void ExitMessage()
        {
            PassMessage("Thank you for using the RECIPE RANDOMIZER! Have a great day!");
            Environment.Exit(0);
        }
       

        public static void MainMenu()
        {
            Console.WriteLine($"What would you like to do?\n1: View All Recipes\n2: Create a New Recipe\n3: Delete A Recipe\n4: RANDOMIZE\n5: Save and Exit");
        }

        public static void MainConsole(List<Recipe> recipes)
        {
            while (true)
            {
                UserInteraction.MainMenu(recipes);
            }
        }
    }
}
