using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SizeOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("The size of int is {0}.", sizeof(Int16));
            Console.WriteLine("The size of short is {0}.", sizeof(short));
            Console.WriteLine("The size of double is {0}.", sizeof(double));

            Int32 fullName = 2;

            Console.WriteLine(fullName);

        }
    }
}
