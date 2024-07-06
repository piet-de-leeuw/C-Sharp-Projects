using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            int numInt;

            MathOverloads overloads = new MathOverloads();

            //Using a interger input. Using overload 1;
            numInt = overloads.Plus(50);
            Console.WriteLine(numInt);

            //Using a decimal input. Using overload 2;
            numInt = overloads.Plus(42.55504m);
            Console.WriteLine(numInt);

            //Using a string input. Throws a error if the string cant be converted. Using overload 3;
            numInt = overloads.Plus("200");
            Console.WriteLine(numInt);

            //Using function with an optional paramether. Using Optional 1
            Console.WriteLine("Please enter a number");
            int numOne, numTwo;
            int result;
            if (!int.TryParse(Console.ReadLine(), out numOne))
            {
                throw new ArgumentException("No valid value");
            }
            Console.WriteLine("Please enter a number -- Optional");
            if(int.TryParse(Console.ReadLine(), out numTwo))
            {
                result = overloads.Subtract(numOne, numTwo);
            }
            else
            {
                result = overloads.Subtract(numOne);
            }
            numInt = overloads.Subtract(numOne, numTwo);
            Console.WriteLine(result);


            Console.ReadLine();
        }
    }
}
