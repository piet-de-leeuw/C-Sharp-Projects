 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Operations.cs
{
    class Program
    {
        static void Main()
        {
            //Add
            float num1 = 5.2f;
            float num2 = 3.332f;
            float totalAdd = num1 + num2;
            Console.WriteLine(num1 + " + " + num2 + " = " + totalAdd);

            //Subtract
            double num3 = 5.334;
            double num4 = 4.332245;
            double totalSubtract = num3 - num4;
            Console.WriteLine(num3 + " - " + num4 + " = " + totalSubtract);

            //Multiply
            decimal num5 = 7.8994m;
            decimal num6 = 4.555000321m;
            decimal totalMultiply = num5 * num6;
            Console.WriteLine(num5 + " x " + num6 + " = " + totalMultiply);

            //Divide (and rounds to int)
            int num7 = 95;
            int num8 = 32;
            int totalDivide = num7 / num8;
            Console.WriteLine(num7 + " : " + num8 + " = " + totalDivide);

            //Remainder
            int num9 = 43;
            int num10 = 32;
            int remainder = num9 % num10;
            Console.WriteLine("the remainder of " + num7 + " : " + num8 + " = " + remainder);

            //This detects if a number is odd or even. remainder of number11 is odd, remainder of 0 number11 is even.
            int number11 = 100;
            int oddOrEven = number11 % 2;
            if (oddOrEven == 0)
            {
                Console.WriteLine(number11 + " is even");
            }
            else
            {
                Console.WriteLine(number11 + " is odd");
            }

            //Assigning a boolean with a comparison.
            bool trueOrFalse = 12 > 5;
            Console.WriteLine(trueOrFalse);

            // > is greater than, < is smaller than, >= is greater or equal to, <= is smaller or equal to.
            int roomTemprature = 70;
            int currentTemprature = 65;
            bool isWarm = currentTemprature >= roomTemprature;
            Console.WriteLine("isWarm = " + isWarm);

            // == is equal to
            bool isEqual = 4 == 5;
            Console.WriteLine(isEqual);

            // != is NOT equal to
            bool isNotEqual = 4 != 5;
            Console.WriteLine(isNotEqual);


            //Waits until a key is pressed before closing the application.
            Console.Read();
        }
    }
}
