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
            if (!ingredients.Exists(x => x.Name == ingredient.Name))
                ingredient.Create(ingredients);
            else
                Console.WriteLine("Такой ингридиент уже есть в списке, нажмите что бы продолжить.");
        }
    }
}
