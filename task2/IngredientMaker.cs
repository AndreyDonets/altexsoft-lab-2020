using System;
using System.Collections.Generic;
using task2.Models;

namespace task2
{
    class IngredientMaker
    {
        public static void Create(List<ModelIngredient> ingredients)
        {
            IngredientHelper ingredient = new IngredientHelper();
            Console.WriteLine("Введите название ингридиента");
            ingredient.Name = Console.ReadLine();
            if (!ingredients.Exists(x => x.Name.Equals(ingredient.Name, StringComparison.CurrentCultureIgnoreCase)))
                ingredient.Add(ingredients);
            else
                Console.WriteLine("Такой ингридиент уже есть в списке, нажмите что бы продолжить.");
            
        }
    }
}
