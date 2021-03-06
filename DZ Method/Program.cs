using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            string userinput = string.Empty;

            userinput = Console.ReadLine();

            WriteError(userinput);
            WriteWarning(userinput);
            WriteColor(userinput);

            Console.ReadKey();
        }

        public static string WriteError(string message)
        {
            ConsoleColor error = ConsoleColor.Red;
            Console.ForegroundColor = error;
            Console.WriteLine(message);
            return message;
        }

        public static string WriteWarning(string message)
        {
            ConsoleColor warning = ConsoleColor.Yellow;
            Console.ForegroundColor = warning;
            Console.WriteLine(message);
            return message;
        }

        public static string WriteColor(string message)
        {
            Random random = new Random();

            int numberColor = random.Next(1, 5 + 1);

            ConsoleColor white = ConsoleColor.White;
            ConsoleColor magenta = ConsoleColor.Magenta;
            ConsoleColor green = ConsoleColor.Green;
            ConsoleColor red = ConsoleColor.Red;
            ConsoleColor blue = ConsoleColor.Blue;

            switch (numberColor)
            {
                case 1:
                    Console.ForegroundColor = white;
                    Console.WriteLine(message);
                    break;
                case 2:
                    Console.ForegroundColor = magenta;
                    Console.WriteLine(message);
                    break;
                case 3:
                    Console.ForegroundColor = green;
                    Console.WriteLine(message);
                    break;
                case 4:
                    Console.ForegroundColor = red;
                    Console.WriteLine(message);
                    break;
                case 5:
                    Console.ForegroundColor = blue;
                    Console.WriteLine(message);
                    break;
                default:
                    break;
            }

            return message;
        }
    }
}
