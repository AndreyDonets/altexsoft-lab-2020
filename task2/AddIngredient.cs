using System;
using System.Collections.Generic;
using task2.Models;

namespace task2
{
    class AddIngredient
    {
        public static void Add(List<modelIngredient> ingredients)
        {
            CreateIngredient ingredient = new CreateIngredient();
            Console.WriteLine("Введите название ингридиента");
            ingredient.Name = Console.ReadLine();
            ingredient.Create(ingredients);
        }
    }
}
