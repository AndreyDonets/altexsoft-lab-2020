using System;
using System.Collections.Generic;
using task2.Model;

namespace task2
{
    class RecipeMaker
    {
        public static Recipe Create(List<Recipe> recipes)
        {
            Console.WriteLine("Придумайте название рецепта, exit для выхода");

            string name = null;
            while (string.IsNullOrWhiteSpace(name))
            {
                name = Console.ReadLine();
                Console.Clear();
                if (string.IsNullOrWhiteSpace(name))
                    Console.WriteLine("Название рецепта не может быть пустым.");
            }
            

            if (!recipes.Exists(x => x.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase)))
            {
                Recipe recipe = new Recipe();
                recipe.Name = name;
                Console.Clear();
                Console.WriteLine("Опишите рецепт");
                string description = null;
                while (string.IsNullOrWhiteSpace(description))
                {
                    description = Console.ReadLine();
                    Console.Clear();
                    if (string.IsNullOrWhiteSpace(description))
                        Console.WriteLine("Описание не может быть пустым.");
                }
                recipe.Description = description;
                recipe.CookingSteps = CookingSteps.Cook();
                Console.Clear();
                return recipe;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Такой рецепт уже есть.");
                return null;
            }
        }
    }
}