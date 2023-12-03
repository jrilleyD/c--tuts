using System;

namespace Inches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long miles = 93000000, inches = miles * 5280 * 12;

            Console.WriteLine("Расстояние до Солнца: " + inches + " дюймов");
        }
    }
}
