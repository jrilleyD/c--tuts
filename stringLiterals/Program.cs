using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringLiterals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "Happy birthday, Joel";
            string b = @"Happy birthday, Joel";
            string c = "hello  \t  world";
            string d = @"hello \t world";
            string e = "Joe said \"Hello\" to me";
            string f = @"Joe said ""Hello"" to me";
            string g = "\\\\server\\share\\file.txt";
            string h = @"\\server\share\file.txt";
            string i = "one\r\ntwo\r\nthree";
            string j = @"one
two
three";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(i);
            Console.WriteLine(j);

            // Delay
            Console.ReadKey();
        }
    }
}
