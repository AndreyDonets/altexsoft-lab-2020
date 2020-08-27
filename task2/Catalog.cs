using System;

namespace task2
{
    class Catalog
    {
        public static void Choose()
        {
            var catalog = CatalogReeder.Read();
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
                        Recipe.Chose("first");
                        break;
                    case "2":
                        Recipe.Chose("second");
                        break;
                    case "3":
                        Recipe.Chose("salad");
                        break;
                }
            }
        }
    }
}
