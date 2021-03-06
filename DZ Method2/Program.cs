using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Method2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            number = int.Parse(Console.ReadLine());

            Square(number);

            Console.ReadKey();
        }

        public static int Square(int square)
        {
            square *= square;
            Console.WriteLine(square);
            return square;
        }
    }
}
