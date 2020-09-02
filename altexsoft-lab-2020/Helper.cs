using System.Globalization;

namespace altexsoft_lab_2020
{
    class Helper
    {
        public static string Cut(string text, string word)
        {
            if (string.IsNullOrEmpty(word))
                return null;
            else
                return text.Contains(word) ? text.Replace(word, string.Empty, true, CultureInfo.InvariantCulture) : null;
        }
    }
}
