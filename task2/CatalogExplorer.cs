using System;
using System.Collections.Generic;
using System.Linq;
using task2.Helpers;
using task2.Model;

namespace task2
{
    class CatalogExplorer
    {
        public static int Choose(List<Category> category)
        {
            Console.Clear();
            Console.WriteLine("Выберите каталог:");
            for (int i = 0; i < category.Count; i++)
            {
                Console.WriteLine($"{i + 1}\t{category[i].Name}");
            }
            Console.WriteLine("exit для выхода из программы");
            string number = Console.ReadLine();
            if (number == "exit")
                Start.Exit(true);
            var n = ParseHelper.Parse(number) - 1;
            if (n >= 0 && n < category.Count)
            {
                return n;
            }
            return -1;
        }
    }
}
