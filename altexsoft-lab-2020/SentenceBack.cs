using System;

namespace altexsoft_lab_2020
{
    class SentenceBack
    {
        public static string ReverseSentence(string sentence)
        {
            string[] newMessage = null;
            if (sentence != null)
            {
                string[] firstOperation = sentence.Split(' ');
                newMessage = new string[firstOperation.Length];
                for (int i = 0; i < firstOperation.Length; i++)
                {
                    char[] letters = firstOperation[i].ToCharArray();
                    Array.Reverse(letters);
                    newMessage[i] = new string(letters);
                }
            }
            return string.Join(" ", newMessage);
        }
    }
}
