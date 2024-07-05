using System;
using System.Collections.Generic;

namespace ExeptionHandeling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> toDivide = new List<int>() { 34, 50, 20, 85, 83, 99, 204, 385 };

                foreach(int number in toDivide)
                {
                    Console.WriteLine(number);
                }
            
            
                Console.WriteLine("Choose a number, the above numbers will be devided by it.");
                int divideBy = Convert.ToInt32(Console.ReadLine());

                foreach(int number in toDivide)
                {
                
                    int result = number / divideBy;
                    Console.WriteLine(result);
                }
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Please enter a whole number");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Can't divide by zero. Try a differend whole number.");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("The program has emerged from the try/catch block and continued on with program execution");
                Console.ReadLine();
            }
        }
    }
}
