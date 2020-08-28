using System;
using System.Collections.Generic;

namespace task2
{
    class CatalogExplorer
    {
        public static void Choose()
        { 
            var reader = new Reader<List<Models.Json>>();
            reader.Path("catalog");
            var catalog = reader.Read();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберите каталог:");
                for (int i = 0; i < catalog.Count; i++)
                {
                    Console.WriteLine($"{i + 1}\t{catalog[i].Name}");
                }
                Console.WriteLine("exit для выхода из программы");
                string number = Console.ReadLine();
                if (number == "exit")
                {
                    Console.Clear();
                    break;
                }
                switch (number)
                {
                    case "1":
                        RecipeSelector.Chose("first");
                        break;
                    case "2":
                        RecipeSelector.Chose("second");
                        break;
                    case "3":
                        RecipeSelector.Chose("salad");
                        break;
                }
            }
        }
    }
}
