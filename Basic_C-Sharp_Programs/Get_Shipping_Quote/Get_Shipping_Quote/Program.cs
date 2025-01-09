using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_Shipping_Quote
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to package express. \nPlease follow the instructions below.");

            Console.WriteLine("What is the weight of your package?");
            float weight = float.Parse(Console.ReadLine());

            if(weight <= 50)
            {
                Console.WriteLine("Enter package width.");
                float width = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter package height.");
                float height = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter package length");
                float length = float.Parse(Console.ReadLine());

                if(width > 50 || height > 50 || length > 50)
                {
                    Console.WriteLine("Package is to big to be shipped with package express");
                }
                else
                {
                    float quote = (width * height * length) * weight / 100;
                    Console.WriteLine("Price for shipping: $" + quote);
                }
            }
            else
            {
                Console.WriteLine("Your package is to heavy to be shipped with package express. \nHave a nice day.");
            }

            Console.ReadLine();
        }
    }
}
