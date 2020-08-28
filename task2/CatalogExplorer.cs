using System;
using System.Collections.Generic;

namespace task2
{
    class CatalogExplorer
    {
        public static void Choose()
        { 
            var reader = new Reader<List<Models.Catalog>>();
            reader.Path("catalog");
            List<Models.Catalog> catalog = reader.Read();
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
                        SubdirectoryExplorer.Chose("first");
                        break;
                    case "2":
                        SubdirectoryExplorer.Chose("second");
                        break;
                    case "3":
                        SubdirectoryExplorer.Chose("salad");
                        break;
                }
            }
        }
    }
}
