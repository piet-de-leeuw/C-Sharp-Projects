using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOverload
{
    public class MathOverloads
    {
        //Overload 1
        public int Plus(int numInt)
        {
            numInt += 100;
            return numInt;
        }

        //Overload 2
        public int Plus(decimal numDecimal)
        {
           int numInt;
           numInt = Convert.ToInt32(numDecimal += 43.50m);
           return numInt;
        }

        //Overload 3
        public int Plus(string stringNumber)
        {
            try
            {
                int numInt;
                numInt = Convert.ToInt32(stringNumber) + 500;
                return numInt;
            }
            catch(FormatException ex)
            {
                int numInt = 1;
                Console.WriteLine("Can't Convert string {0} into int, returned numInt as 1" );
                Console.ReadLine();
                return numInt;

            }

        }


    }
}