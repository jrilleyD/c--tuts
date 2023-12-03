using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введитте первое слагаемое: ");
            string stringAugend = Console.ReadLine();

            Console.Write("Введите второе слагаемое: ");
            string stringAddend = Console.ReadLine();

            int augend = Convert.ToInt32(stringAugend);
            int addend = Convert.ToInt32(stringAddend);

            int sum = augend + addend;

            string result = $"{augend} + {addend} = {sum}";

            result += "!";

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
