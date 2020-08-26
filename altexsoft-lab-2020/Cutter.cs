using System;

namespace altexsoft_lab_2020
{
    class Cutter
    {
        public static void Cut()
        {
            
            string text = Text.Get();
            Console.WriteLine("Введите символ/слово для удаления");
            string word = Console.ReadLine();
            Console.Clear();
            var result = CarversHepler.Cut(text, word);
            Console.WriteLine(string.IsNullOrEmpty(result) ? (word + " в тексте нет") : result);
            Console.WriteLine("Нажмите чтобы продолжить");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
