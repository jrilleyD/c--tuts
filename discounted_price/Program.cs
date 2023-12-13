using System;


namespace discounted_price
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal price = 19.75m;
            decimal discount = 0.015m;
            decimal discountedPrice = price - (price * discount);

            Console.WriteLine($"Discounted price: {discountedPrice}");
        }
    }
}
