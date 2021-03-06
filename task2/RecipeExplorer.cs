using System;
using System.Collections.Generic;
using task2.Model;

namespace task2
{
    class RecipeExplorer
    {
        public static void Overview(Recipe recipe, List<Ingredient> ingredients)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(recipe.Name);
                Console.WriteLine($"\nОписание");
                Console.WriteLine(recipe.Description);
                Console.WriteLine($"\nИнгридиенты:");
                int i = 0;
                foreach (var item in recipe.Ingredients)
                {
                    i++;
                    Console.WriteLine(i + " " + ingredients[item.Id].Name + " " + item.Quantity);
                }
                Console.WriteLine($"\nШаги приготовления:");
                foreach (var item in recipe.CookingSteps)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("\nback для выбора другого рецепта");
                string s = Console.ReadLine();
                if (s == "back")
                {
                    break;
                }
            }
            Console.Clear();
        }
    }
}
