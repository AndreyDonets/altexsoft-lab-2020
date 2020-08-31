using System;
using System.Collections.Generic;
using task2.Helpers;
using task2.Model;

namespace task2
{
    class IngredientSelector
    {
        public static List<string> Choose(List<Ingredient> ingredients)
        {
            List<string> recipeIngredients = new List<string>();
            while (true)
            {
                IngredientHelper.Show(ingredients, recipeIngredients.Count);
                string number = null;
                while (string.IsNullOrWhiteSpace(number))
                {
                    number = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(number))
                    {
                        Console.Clear();
                        Console.WriteLine("Вы не выбрали ингридиент.");
                        IngredientHelper.Show(ingredients, recipeIngredients.Count);
                    }
                }
                Console.Clear();

                if (recipeIngredients.Count > 0 && number == "exit")
                    break;
                var numberIngredient = ParseHelper.Parse(number);
                if (numberIngredient >= 0 && numberIngredient <= ingredients.Count)
                {
                    numberIngredient--;
                    Console.WriteLine("Введите количество");
                    string count = Console.ReadLine();
                    recipeIngredients.Add(ingredients[numberIngredient].Name + " " + count);
                    ingredients.RemoveAt(numberIngredient);
                }
                else if (numberIngredient == ingredients.Count + 1)
                {
                    ingredients = IngredientMaker.Create(ingredients);
                    Console.WriteLine("Ингридиент добавлен в список ингридиентов");
                }
            }
            return recipeIngredients;
        }
    }
}