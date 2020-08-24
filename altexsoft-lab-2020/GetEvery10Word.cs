using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace altexsoft_lab_2020
{
    class GetEvery10Word
    {
        public static string GetTenWorlds(MatchCollection text)
        {
            var ever = new List<string>();
            for (var index = 0; index < text.Count; index++)
            {
                if (index >= 1 && index % 10 == 0)
                {
                    ever.Add(text[index - 1].Value);
                }
            }

            return string.Join(", ", ever.ToArray());
        }
    }
}
