using System;
using System.Collections.Generic;
using System.Linq;
using task2.Model;

namespace task2
{
    class RecipeSelector
    {
        public static Recipe Chose(List<Recipe> recipe, List<Ingredient> ingredients)
        {
            Console.Clear();
            Console.WriteLine("Выберите рецепт:");
            int i = 0;
            for (; i < recipe.Count; i++)
            {
                Console.WriteLine($"{i + 1}\t{recipe[i].Name}");
            }

            Console.WriteLine($"{i + 1}\tдля создания нового рецепта");
            Console.WriteLine($"back - вернуться к выбору категорий");
            string number = Console.ReadLine();
            if (number == "back")
                Start.Back(true);
            Console.Clear();
            if (int.TryParse(number, out int n))
            {
                if (n <= recipe.Count && n >= 0)
                {
                    RecipeExplorer.Overview(recipe[n - 1], ingredients);
                    return null;
                }
                else if (n == recipe.Count + 1)
                {
                    return new Recipe();
                }

            }
            return null;
        }
    }
}