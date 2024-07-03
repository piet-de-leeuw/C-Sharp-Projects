using System;

namespace Qualify_For_Car_Insurance
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            bool oldEnough = age > 15;

            Console.WriteLine("\nHave you ever had a DUI?");
            Console.WriteLine("please enter \"true\" or \"false\"");
            bool hasDUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("\nHow many speeding tickets do you have?");
            int AmountSpeedingTickets = Convert.ToInt32(Console.ReadLine());
            bool lowAmoundSpeedingTicket = AmountSpeedingTickets <= 3;

            bool isQualified = oldEnough && !hasDUI && lowAmoundSpeedingTicket;
            Console.WriteLine("\nQualify's for a car insurance: " + isQualified);

            Console.Read();
        }
    }
}
