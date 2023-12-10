using System;
using System.Text.RegularExpressions;

namespace XOR_HomeWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = Math.PI;
            long tenThousand = 10000L;
            double tenThousandPi = (double)pi * tenThousand;
            int roundedTenThousandPi = (int)Math.Round(tenThousandPi);

            Console.ReadKey();
        }
    }
}
