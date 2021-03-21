using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Method8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            QuadraticEquation(a,b,c);

            Console.ReadKey();
        }

        public static void QuadraticEquation(int a, int b, int c)
        {
            double D = (b * b) - (4 * a * c);
            Console.WriteLine("Дескриминант: " + D);
            double SqrtD = Math.Sqrt(D);

            double x1 = (-b + SqrtD)/(2*a);
            double x2 = (-b - SqrtD) / (2 * a);

            Console.WriteLine("x1: " + x1);
            Console.WriteLine("x2: " + x2);
        }
    }
}
