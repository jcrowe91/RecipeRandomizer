using System;
using System.Collections.Generic;

namespace RecipeRandomizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new();
            List<RecipeBook> food = new();
            food.Add(new RecipeBook("Tacos", 1));
            food.Add(new RecipeBook("Burgers", 1));
            food.Add(new RecipeBook("Crock Pot Roast", 2));
            food.Add(new RecipeBook("Bagged Chicken", 2));
            food.Add(new RecipeBook("Tater Tot Casserole", 2));
            food.Add(new RecipeBook("Steaks", 1));
            food.Add(new RecipeBook("Dirty Rice and Drop Biscuits", 2));


            foreach (RecipeBook sample in food)
            {
                Console.WriteLine($"{sample.Name} which lasts {sample.Days} night(s)");
            }

            Console.ReadLine();
        }

    }
}
