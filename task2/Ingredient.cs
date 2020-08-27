using System;
using System.Collections.Generic;
using task2.Reader;

namespace task2
{
    class Ingredient
    {
         public static List<string> Choose()
        {
            var ingredients = IngredientReeder.Read();
            List<string> s = new List<string>();
            while (true)
            {
                Console.WriteLine("Выберите ингридиенты:");
                int i = 0;
                for (; i < ingredients.Count; i++)
                {
                    Console.WriteLine($"{i + 1}\t{ingredients[i].Name}");
                }
                Console.WriteLine($"{i + 1}\tдобавить новый ингридиент");
                Console.WriteLine("exit для выхода");
                string number = Console.ReadLine();
                Console.Clear();
                int n = -1;
                if (int.TryParse(number, out n))
                {
                    if (n <= ingredients.Count)
                    {
                        n--;
                        Console.WriteLine("Введите количество");
                        string count = Console.ReadLine();
                        s.Add(ingredients[n].Name + " " + count);
                        ingredients.RemoveAt(n);
                    }
                    else if (n == ingredients.Count + 1)
                    {
                        IngredientMaker.Create(ingredients);
                        Console.WriteLine("Ингридиент добавлен в список");
                    }
                }
                else if (number == "exit")
                {
                    break;
                }
            }
            return s;
        }
    }
}
