using System;
using System.Collections.Generic;
using task2.Models;

namespace task2
{
    class RecipeMaker
    {
        public static void Create(List<modelSubdirectory> recipes, string path)
        {
            Console.WriteLine("Придумайте название рецепта, exit для выхода");

            while (true)
            {
                string name = Console.ReadLine();
                if (name == "exit")
                {
                    break;
                }
                if (!recipes.Exists(x => x.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase)))
                {
                    RecipeHelper recipe = new RecipeHelper();
                    Console.WriteLine("Опишите рецепт");
                    recipe.Name = name;
                    recipe.Description = Console.ReadLine();
                    recipe.Ingredients = Ingredient.Choose();
                    recipe.Cooking = CookingSteps.Cook();
                    SubdirectoryHelper changeSubdirectory = new SubdirectoryHelper();
                    recipe.Add(recipe);
                    changeSubdirectory.Add(recipes, recipe.Name, path);
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Такой рецепт уже есть, придумайте другой, exit для выхода");
                }
            }
        }
    }
}