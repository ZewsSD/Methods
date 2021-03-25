using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Method13
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            GetTextStatistics(text);

            Console.ReadKey();
        }

        public static string GetTextStatistics(string text)
        {
            string vowels = "ауоыиэяюёе";
            int qtyVowels = 0;
            string consonants = "бвгджзйклмнпрстфхцчшщ";
            int qtyConsonants = 0;
            int qtyNumerals = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (vowels.Contains(text[i]) == true)
                {
                    qtyVowels++;
                }
            }

            Console.WriteLine(qtyVowels);

            for (int i = 0; i < text.Length; i++)
            {
                if (consonants.Contains(text[i]) == true)
                {
                    qtyConsonants++;
                }
            }

            Console.WriteLine(qtyConsonants);

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]) == true)
                {
                    qtyNumerals++;
                }
            }

            Console.WriteLine(qtyNumerals);

            return text;
        }
    }
}
