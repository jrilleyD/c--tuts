using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicalOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = true;
            string y = "1";

            bool isEqual = x == y;
            Console.WriteLine($"{x} == {y} = {isEqual}");
            
            bool isNotEqual = x != y;
            Console.WriteLine($"{x} != {y} = {isNotEqual}");

            bool isGreater = x > y;
            Console.WriteLine($"{x} > {y} = {isGreater}");

            bool isLess = x < y;
            Console.WriteLine($"{x} < {y} = {isLess}");

            bool isGreaterOrEqual = x >= y;
            Console.WriteLine($"{x} >= {y} = {isGreaterOrEqual}");

            bool isLessOrEqual = x <= y;
            Console.WriteLine($"{x} <= {y} = {isLessOrEqual}");

            Console.ReadKey();
        }
    }
}
