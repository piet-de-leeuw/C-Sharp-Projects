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


            Console.ReadLine();
        }
    }
}
