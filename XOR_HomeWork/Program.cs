using System;

namespace XOR_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Last name of the person applying for the subsidy: ");
            string lastName = Console.ReadLine();

            Console.Write($"Is {lastName} pensioner?(y/n): ");
            bool isPensioner = Console.ReadLine().Contains("y");

            Console.Write($"Is {lastName} registered with the employment service?(y/n): ");
            bool isUnemployed = Console.ReadLine().Contains("y");

            Console.Write($"Is {lastName} employment?(y/n): ");
            bool isEmployment = Console.ReadLine().Contains("y");

            bool subsidyAllowed = isPensioner ^ (isUnemployed || isEmployment);

            Console.WriteLine($"{subsidyAllowed}");

            Console.ReadKey();
        }
    }
}
