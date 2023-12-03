using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringVariables_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typedChar1 = Console.ReadLine();
            string typedChar2 = Console.ReadLine();
            string typedChar3 = Console.ReadLine();
            string typedChar4 = Console.ReadLine();
            string typedChar5 = Console.ReadLine();
            string[] strings = { typedChar1, typedChar2, typedChar3, typedChar4, typedChar5 };

            char result;

            foreach (string strng in strings)
            {
                result = Convert.ToChar(strng[0]);
                Console.WriteLine(result);
            }

            /*char result;

            foreach (string strng in strings)
            {
                try
                {
                    result = Convert.ToChar(strng[0]);
                    Console.WriteLine($"'{result}'");
                } 
                catch (FormatException)
                {
                    result = Convert.ToChar(strng[0]);
                    Console.WriteLine($"{result}");
                } 
                catch (ArgumentNullException)
                {
                    Console.WriteLine("A null string cannot be converted to a Char.");
                }
            }*/

        }
    }
}
