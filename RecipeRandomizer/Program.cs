using System;
using System.Collections.Generic;

namespace RecipeRandomizer
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Recipe> recipe = new();

            ConsoleLogging.WelcomeMessage();

            FileManipulation.LoadRecipes(recipe);

            ConsoleLogging.MainConsole(recipe);
           
        }

    }
}
