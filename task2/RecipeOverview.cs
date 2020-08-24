using System;
using task2.Reader;

namespace task2
{
    class RecipeOverview
    {
        public static void recipeOverview(string path)
        {
            var recipe = RecipeReed.Read(path);
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
                    Console.WriteLine(i + " " + item);
                }
                Console.WriteLine($"\nШаги приготовления:");
                foreach (var item in recipe.Cooking)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("\nexit для выбора другого рецепта");
                string s = Console.ReadLine();
                if (s == "exit")
                {
                    break;
                }
            }
            Console.Clear();
        }
    }
}
