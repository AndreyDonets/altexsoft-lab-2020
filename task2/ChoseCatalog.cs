using System;

namespace task2
{
    class ChoseCatalog
    {
        public static void ChooseCatalog()
        {
            var catalog = CatalogReed.Read();
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
                        ChooseRecipe.Chose("first");
                        break;
                    case "2":
                        ChooseRecipe.Chose("second");
                        break;
                    case "3":
                        ChooseRecipe.Chose("salad");
                        break;
                }
            }
        }
    }
}
