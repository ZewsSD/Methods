using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Method10
{
    class Program
    {
        static void Main(string[] args)
        {
            int networkSpeedInKBit = int.Parse(Console.ReadLine());
            int fileSizeInByte = int.Parse(Console.ReadLine());

            CalculateFileTransfers(networkSpeedInKBit, fileSizeInByte);

            Console.ReadKey();
        }

        public static int CalculateFileTransfers(int networkSpeedInKBit, int fileSizeInByte)
        {
            int losses = fileSizeInByte / 4;    
            fileSizeInByte -= losses;

            int fileSizeInBit = fileSizeInByte * 8;

            int networkSpeedInBit = networkSpeedInKBit * 1000;

            int timeInSec = fileSizeInBit / networkSpeedInBit;

            Console.WriteLine(timeInSec);

            return timeInSec;
        }
    }
}
