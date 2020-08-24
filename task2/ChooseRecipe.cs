using System;
using task2.Reader;

namespace task2
{
    class ChooseRecipe
    {
        public static void Chose(string path)
        {
            Console.Clear();
            var recipes = SubdirectoryReed.Read(path);
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
                int n;
                if (int.TryParse(number, out n))
                {
                    if (n <= recipes.Count && n >= 0)
                    {
                        n--;
                        RecipeOverview.recipeOverview(recipes[n].Name);
                    }
                    else if (n == recipes.Count + 1)
                    {
                        CreateRecipe.Create(recipes, path);
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
