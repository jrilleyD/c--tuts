using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringLiterals_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*          Console.Write("Enter your name: ");
                      string name = Console.ReadLine();
                      Console.Write("Enter your surname: ");
                      string surname = Console.ReadLine();
                      string result = $"Hello {{{name,-20}}} {{{surname}}}!\nIt\'s a good day today!";*/

            Console.Write("Enter a num: ");
            int userEnNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(String.Format("{0:000000}", userEnNum));

            Console.ReadKey();
        }
    }
}
