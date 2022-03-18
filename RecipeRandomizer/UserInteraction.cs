using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeRandomizer
{
    class UserInteraction
    {       

        public static void MainMenu(List<Recipe> recipes)
        {            
            ConsoleLogging.MainMenu();
            int userAnswer = Convert.ToInt32(Console.ReadLine());

            if (userAnswer == 1)
            {
                ConsoleLogging.ClearConsole();
                GetAllRecipes(recipes);
            }
            else if (userAnswer == 2)
            {
                ConsoleLogging.ClearConsole();
                var newRecipe = AddNewRecipe();
                recipes.Add(newRecipe);
            }
            else if (userAnswer == 3)
            {
                ConsoleLogging.ClearConsole();
                DeleteRecipe(recipes);
            }
            else if (userAnswer == 4)
            {
                ConsoleLogging.ClearConsole();
                RandomizeRecipes(recipes);
            }
            else if (userAnswer == 5)
            {
                ConsoleLogging.ClearConsole();
                FileManipulation.SaveRecipes(recipes);
                ConsoleLogging.ExitMessage();
            }
            else
            {
                ConsoleLogging.InvalidInput();
            }
        }

        public static void GetAllRecipes(List<Recipe> recipes)
        {
            Console.WriteLine("-------------------------");
            foreach (var item in recipes)
            {
                ConsoleLogging.PassMessage($"Recipe: {item.NameOfRecipe} which lasts {item.Days} day(s)!");
            }
            Console.WriteLine("-------------------------");
        }

        public static Recipe AddNewRecipe()
        {
            var recipe = new Recipe();

            ConsoleLogging.PassMessage("What do you call this recipe?");
            recipe.NameOfRecipe = Console.ReadLine();

            ConsoleLogging.PassMessage("How many days does this recipe usually last?");
            recipe.Days = Console.ReadLine();

            return recipe;
        }

        public static void DeleteRecipe(List<Recipe> recipes)
        {
            for (int i = 0; i < recipes.Count; i++)
            {
                Console.WriteLine($"ID: {i + 1} Recipe: {recipes[i].NameOfRecipe} which lasts {recipes[i].Days} day(s)");
                Console.WriteLine("-----------------------------");
            }

            ConsoleLogging.PassMessage("What is the ID of the recipe you'd like to delete?");
            var recipeID = Convert.ToInt32(Console.ReadLine());

            recipes.RemoveAt(recipeID - 1);
            ConsoleLogging.PassMessage("Success!");
        }

        public static void RandomizeRecipes(List<Recipe> recipes)
        {
            Random rng = new();
            List<Recipe> randoRecipes = new List<Recipe>(recipes);           
            

            var sample = randoRecipes[rng.Next(randoRecipes.Count())];
            Console.WriteLine($"{sample.NameOfRecipe} which lasts {sample.Days} night(s)");
            randoRecipes.Remove(sample);

            sample = randoRecipes[rng.Next(randoRecipes.Count())];
            Console.WriteLine($"{sample.NameOfRecipe} which lasts {sample.Days} night(s)");
            randoRecipes.Remove(sample);

            sample = randoRecipes[rng.Next(randoRecipes.Count())];
            Console.WriteLine($"{sample.NameOfRecipe} which lasts {sample.Days} night(s)");
            randoRecipes.Remove(sample);


            if (Convert.ToInt32(sample.Days) != 7)
            {
                sample = randoRecipes[rng.Next(randoRecipes.Count())];
                Console.WriteLine($"{sample.NameOfRecipe} which lasts {sample.Days} night(s)");
                randoRecipes.Remove(sample);
            }

            if (Convert.ToInt32(sample.Days) != 7)
            {
                sample = randoRecipes[rng.Next(randoRecipes.Count())];
                Console.WriteLine($"{sample.NameOfRecipe} which lasts {sample.Days} night(s)");
                randoRecipes.Remove(sample);
            }
        }
    }


}
