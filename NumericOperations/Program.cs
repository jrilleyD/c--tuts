using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte augend = 1, addend = 2;
            byte sum = (byte)(augend + addend);

            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
