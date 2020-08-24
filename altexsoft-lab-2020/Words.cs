using System;

namespace altexsoft_lab_2020
{
    class Words
    {
        public static void WordsCount()
        {
            var allWords = GetEveryWord.GetWords();
            if (allWords != null)
            {
                var everyTenString = GetEvery10Word.GetTenWorlds(allWords);
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
