using System;
using System.Collections.Generic;
using System.IO;

namespace altexsoft_lab_2020
{
    class DictionariesAndFiles
    {
        public static void FindAndWrite()
        {
            Console.WriteLine("Введите путь к файлу");
            string path = Console.ReadLine();
            Console.Clear();
            if (Directory.Exists(path))
            {
                while (true)
                {
                    Console.Clear();
                    Dictionary<int, string> openWith = DictionaryHelper.GetDictionariesAndFiles(path);
                    if (path == "exit")
                        break;
                    Console.WriteLine("Выберите директорию или файл по номеру:");
                    foreach (KeyValuePair<int, string> kvp in openWith)
                    {
                        int openIndex = kvp.Value.IndexOf(' ');
                        int closeIndex = kvp.Value.LastIndexOf('\\');
                        string a = kvp.Value.Remove(kvp.Value.IndexOf(' ') + 1, closeIndex - openIndex);
                        Console.WriteLine("{0}\t{1}",
                            kvp.Key, a);
                    }
                    if (int.TryParse(Console.ReadLine(), out int number))
                    {
                        openWith.TryGetValue(number, out string open);
                        path = open.Substring(open.IndexOf(' ') + 1);
                        Console.Clear();
                        if (File.Exists(path))
                        {
                            Console.WriteLine("Поздравляю вы нашли то что искали, нажмите любую клавишу чтобы продолжить");
                            Console.ReadLine();
                            break;
                        }
                        openWith.Clear();
                    }
                }
            }
        }
    }
}
