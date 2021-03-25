
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Method9
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double interestRate = double.Parse(Console.ReadLine());
            int investmentTerm = int.Parse(Console.ReadLine());

            GetCapital(money, interestRate, investmentTerm);

            Console.ReadKey();
        }

        public static double GetCapital(double money, double interestRate, int investmentTerm)
        {
            interestRate /= 100;

            for (int i = 0; i < investmentTerm; i++)
            {
                money += money * interestRate;
                Console.WriteLine(money);
            }

            return money;
        }
    }
}
