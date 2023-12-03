using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 12, z = 3;

            Console.WriteLine(x = x + ++x);
            Console.WriteLine($"x += y - ++x * z {x = x + y - (++x * z)}");
            Console.WriteLine($"z = --x - y * 5 {z = --x - y * 5}");
            Console.WriteLine($"y /= x + 5 % z {y /= x + 5 % z}");
            Console.WriteLine($"z = ++x + y * 5 {z = ++x + y * 5}");
            Console.WriteLine($"x = y - ++x * z {x = y = ++x * z}");

            Console.ReadKey();
        }
    }
}
