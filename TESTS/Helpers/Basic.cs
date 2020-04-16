using System;
using System.Collections.Generic;
using System.Text;

namespace TESTS.Helpers
{
    public static class Basic
    {
        public static Dictionary<char, int> CountLetters(string text)
        {
            var dict = new Dictionary<char, int>();
            foreach (var letter in text)
            {
                if (!dict.ContainsKey(letter))
                {
                    dict.Add(letter, 1);
                }
                else
                {
                    dict[letter]++;
                }
            }
            return dict;
        }


    }
}
