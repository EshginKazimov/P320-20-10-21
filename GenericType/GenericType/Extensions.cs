using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericType
{
    static class Extensions
    {
        public static string[] GetUpperWords(this string text)
        {
            //char[] symbols = { '.', ' ', ',', '?' };
            string[] symbols = { ".", " ", ", ", "? " };

            string[] words = text.Split(symbols, StringSplitOptions.RemoveEmptyEntries);
            //string[] words = text.Split(symbols);
            string[] result = new string[0];

            foreach (var word in words)
            {
                if (char.IsUpper(word[0]))
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[result.Length - 1] = word;
                }
            }

            return result;
        }
    }
}
