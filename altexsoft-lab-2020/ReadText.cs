using System;
using System.IO;

namespace altexsoft_lab_2020
{
    class ReadText
    {
        public static string GetText()
        {
            Console.WriteLine("Введите путь к файлу");
            string path = Console.ReadLine();
            Console.Clear();
            try
            {
                return File.ReadAllText(path);
            }
            catch
            {
                return null;
            }
        }
    }
}
