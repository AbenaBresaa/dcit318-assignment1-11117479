using System;

namespace TicketPriceCalculator
{
    class ticketPriceCalculator
    {
        static void Main(string[] args)
        {
            Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            int price = 10;

            // Discount for seniors (65+) and children (12 and under)
            if (age >= 65 || age <= 12)
            {
                price = 7;
            }

            Console.WriteLine("Ticket price is GHC" + price);
        }
    }
}
