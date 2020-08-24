using System;
using System.Collections.Generic;
using task2.Models;

namespace task2
{
    class CreateRecipe
    {
        public static void Create(List<modelSubdirectory> recipes, string path)
        {
            CreateRecipeFinish recipe = new CreateRecipeFinish();
            Console.WriteLine("Придумайте название рецепта");
            recipe.Name = Console.ReadLine();
            Console.WriteLine("Опишите рецепт");
            recipe.Description = Console.ReadLine();
            recipe.Ingredients = ChooseIngredient.Choose();
            recipe.Cooking = CookingSteps.Cook();
            ChangeSubdirectory changeSubdirectory = new ChangeSubdirectory();
            recipe.Create(recipe);
            changeSubdirectory.ChangeSub(recipes, recipe.Name, path);
            Console.Clear();
        }
    }
}