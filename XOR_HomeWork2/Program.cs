using System;

namespace XOR_HomeWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Employee`s last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Experience: ");
            int experience = Convert.ToInt32(Console.ReadLine());

            bool result = experience < 5 || experience >= 5 & experience < 10 || experience >= 10 & experience < 15 || experience >= 15 & experience < 25 ;

            Console.ReadKey();
        }
    }
}
