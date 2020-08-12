using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;

namespace altexsoft_lab_2020
{
    public class TextFormatHelper
    {
        public string GetTextFromFile(string way)
        {
            try
            {
                return File.ReadAllText(way);
            }
            catch
            {
                return null;
            }
        }

        public string Cut(string text, string word)
        {
            if (string.IsNullOrEmpty(word))
                return null;
            else
                return text.Contains(word) ? text.Replace(word, string.Empty, true, CultureInfo.InvariantCulture) : null;
        }

        public int GetEveryWord(string path)
        {
            string pattern = @"\w+'*\w*";
            Regex rgx = new Regex(pattern);
            return rgx.Matches(path).Count;
        }

        public string GetEvery10Word(string text)
        {
            var ever = new List<string>();
            string pattern = @"\w+'*\w*";
            Regex rgx = new Regex(pattern);
            var eve = rgx.Matches(text);

            for (var index = 0; index < eve.Count; index++)
            {
                if (index >= 1 && index % 10 == 0)
                {
                    ever.Add(eve[index - 1].Value);
                }
            }

            return string.Join(", ", ever.ToArray());
        }
        public string ThirdSentences(string text)
        {
            string sentence = null;
            int openingPosition;
            for (int i = 0; i < 3; i++)
            {

                openingPosition = text.IndexOf('.');
                if (openingPosition == -1)
                    break;
                openingPosition += 1;
                if (i == 2)
                    sentence = text.Substring(0, openingPosition);
                else
                    sentence = null;
                text = text.Substring(openingPosition + 1);
            }
            return sentence;
        }
        public string SentenseBack(string sentence)
        {
            string[] firstOperation = sentence.Split(' ');
            string[] newMessage = new string[firstOperation.Length];

            for (int i = 0; i < firstOperation.Length; i++)
            {
                char[] letters = firstOperation[i].ToCharArray();
                Array.Reverse(letters);
                newMessage[i] = new string(letters);
            }

            return string.Join(" ", newMessage);
        }
        public Dictionary<int, string> Value(string path)
        {

            Dictionary<int, string> openWith = new Dictionary<int, string>();
            
            string[] dirs = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);
            Array.Sort(dirs);
            Array.Sort(files);
            for (int i = 0; i < dirs.Length; i++)
            {
                openWith.Add(i + 1, "dir\t " + dirs[i]);
            }
            for (int j = 0, i = dirs.Length; i < dirs.Length + files.Length; i++, j++)
            {
                openWith.Add(i + 1,"file\t " + files[j]);
            }
            openWith.Add(openWith.Count + 1, "exit");
            return openWith;
        }
    }
}
