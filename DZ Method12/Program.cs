using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Method12
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            GetCapitalLettersInText(text);

            Console.ReadKey();
        }

        public static string GetCapitalLettersInText(string text)
        {
            int qtyCapitalLetters = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]) == true)
                {
                    qtyCapitalLetters++;

                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();

            Console.WriteLine(qtyCapitalLetters);

            return text;
        }
    }
}
