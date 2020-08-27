using System;

namespace altexsoft_lab_2020
{
    class Words
    {
        public static void Count()
        {
            var allWords = AllWords.Get();
            if (allWords != null)
            {
                var everyTenString = TenWord.Get(allWords);
                Console.Clear();
                Console.WriteLine(everyTenString);
                Console.WriteLine($"Слов в тексте: {allWords.Count}");
                Console.WriteLine("Нажмите чтобы продолжить");
                Console.ReadLine();
                Console.Clear();
            }
            else
                Console.WriteLine("result is null");
        }
    }
}
