using System;
using System.Collections.Generic;
using System.Text;
using task2.Model;

namespace task2
{
    class IngredientHelper
    {
        public static void Show(List<Ingredient> ingredients, int count)
        {
            int i = 1;
            Console.WriteLine("Выберите ингридиенты:");
            foreach (var ingredient in ingredients)
            {
                Console.WriteLine($"{i}\t{ingredient.Name}");
                i++;
            }

            Console.WriteLine($"{i}\tдобавить новый ингридиент");
            if (count > 0)
            {
                Console.WriteLine($"exit - закончить с выбором ингридиентов");
            }
        }
    }
}
