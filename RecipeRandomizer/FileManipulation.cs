using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RecipeRandomizer
{
    public class FileManipulation
    {
        public static string GetFilePath()
        {
            string filePath = $"{Directory.GetCurrentDirectory()}/Recipes.txt";
            return filePath;
        }

        public static void LoadRecipes(List<Recipe> recipes)
        {
            string filePath = GetFilePath();

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            List<string> lines = File.ReadAllLines(filePath).ToList();

            if (lines.Count == 0)
            {
                return;
            }

            foreach (var line in lines)
            {
                string[] entries = line.Split(',');


                Recipe newRecipe = new Recipe()
                {
                    NameOfRecipe = entries[0],
                    Days = entries[1],
                };


                recipes.Add(newRecipe);
            }
        }

        public static void SaveRecipes(List<Recipe> recipe)
        {
            List<string> output = new List<string>();
            string filePath = GetFilePath();

            foreach (var item in recipe)
            {
                output.Add($"{item.NameOfRecipe},{item.Days}");
            }

            File.WriteAllLines(filePath, output);

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(300);
                Console.Write('.');
            }

        }
    }
}
