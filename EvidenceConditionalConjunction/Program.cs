using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenceConditionalConjunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Enter age: ");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter salary: ");
            int Salary = Convert.ToInt32(Console.ReadLine());

            int minAge = 21;
            int maxAge = 60;
            int MinimumWage = 2100;

            bool BankLoan = Age >= minAge & Salary >= MinimumWage & Age <= maxAge;

            Console.WriteLine($"Result is: {BankLoan}");*/

            int firstNumber = 0;
            bool simpleLogicResult = true & false && (firstNumber++ > 0);
            Console.WriteLine($"firstNumber = {firstNumber}");

            int secondNumber = 0;
            bool simpleLogicResult2 = true && false & (secondNumber++ > 0);
            Console.WriteLine($"firstNumber = {secondNumber}");

            Console.ReadKey();
        }
    }
}
