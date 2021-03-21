using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Method6
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            CutWords(ref str);
            Console.WriteLine(str);

            Console.ReadKey();
        }

        public static string CutWords(ref string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]) != true)  
                {
                    text = text.Remove(i, 1);
                    i--;
                }
            }

            return text;
        }
    }
}
