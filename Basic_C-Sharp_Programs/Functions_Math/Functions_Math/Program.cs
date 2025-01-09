using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number");
            int number = Convert.ToInt32(Console.ReadLine());


            number = My_Functions.PlusFive(number);
            Console.WriteLine(number);
            number = My_Functions.MultiplyByTen(number);
            Console.WriteLine(number);
            number = My_Functions.DivideByFive(number);
            Console.WriteLine(number);

            Console.ReadLine();
        }
    }
}
