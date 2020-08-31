using System;
using System.Collections.Generic;
using task2.Model;

namespace task2
{
    class IngredientMaker
    {
        public static List<Ingredient> Create(List<Ingredient> ingredients)
        {
            Console.WriteLine("Введите название ингридиента");
            string name = null;
            while (string.IsNullOrWhiteSpace(name))
            {
                name = Console.ReadLine();
                Console.Clear();
                if (string.IsNullOrWhiteSpace(name))
                    Console.WriteLine("Название рецепта не должно быть пустым");
            }
            if (!ingredients.Exists(x => x.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase)))
            {
                Ingredient ingredient = new Ingredient();
                ingredient.Id = ingredients.Count;
                ingredient.Name = name;
                ingredients.Add(ingredient);
                Start.AddIngredient(ingredient);
            }
            else
            {
                Console.WriteLine("Такой ингридиент уже есть в списке, нажмите что бы продолжить. Нажмите что бы продолжить.");
                Console.ReadLine();
            }
            return ingredients;
        }
    }
}
