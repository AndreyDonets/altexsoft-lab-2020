using System;
using System.Collections.Generic;
using task2.Models;

namespace task2
{
    class CreateRecipe
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
                if (!recipes.Exists(x => x.Name == name))
                {
                    CreateRecipeFinish recipe = new CreateRecipeFinish();
                    Console.WriteLine("Опишите рецепт");
                    recipe.Name = name;
                    recipe.Description = Console.ReadLine();
                    recipe.Ingredients = ChooseIngredient.Choose();
                    recipe.Cooking = CookingSteps.Cook();
                    ChangeSubdirectory changeSubdirectory = new ChangeSubdirectory();
                    recipe.Create(recipe);
                    changeSubdirectory.ChangeSub(recipes, recipe.Name, path);
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