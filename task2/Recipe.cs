using System;
using System.Collections.Generic;

namespace task2
{
    class Recipe
    {
        public static void Chose(string path)
        {
            Console.Clear();
            var reader = new Reader<List<Models.Json>>();
            reader.Path(path);
            var recipes = reader.Read();
            while (true)
            {
                Console.WriteLine("Выберите рецепт:");
                int i = 0;
                for (; i < recipes.Count; i++)
                {
                    Console.WriteLine($"{i + 1}\t{recipes[i].Name}");
                }
                Console.WriteLine($"{i + 1}\tдля создания нового рецепта");
                Console.WriteLine("exit для выхода из программы");
                string number = Console.ReadLine();
                Console.Clear();
                if (int.TryParse(number, out int n))
                {
                    if (n <= recipes.Count && n >= 0)
                    {
                        n--;
                        RecipeExplorer.Overview(recipes[n].Name);
                    }
                    else if (n == recipes.Count + 1)
                    {
                        RecipeMaker.Create(recipes, path);
                    }
                }
                else if (number == "exit")
                {
                    break;
                }
            }
        }
    }
}
