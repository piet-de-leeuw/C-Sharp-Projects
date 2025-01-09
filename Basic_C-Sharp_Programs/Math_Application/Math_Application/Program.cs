using System;


namespace Math_Application
{
    class Program
    {
        static void Main()
        {

            //Multiply user input by 50.
            Console.WriteLine("Please enter a number");
            double number1 = Convert.ToDouble(Console.ReadLine());
            double result1 = number1 * 50;
            Console.WriteLine(number1 + " x 50 = " + result1);

            //Add 25 to user input.
            Console.WriteLine("Please enter a number");
            float number2 = float.Parse(Console.ReadLine());
            float result2 = number2 + 25;
            Console.WriteLine(number2 + " + 25 = " + result2);

            //Divide user input by 12.5.
            Console.WriteLine("Please enter a number");
            float number3 = float.Parse(Console.ReadLine());
            float result3 = number3 + 12.5f;
            Console.WriteLine(number3 + " : 12.5 = " + result3);

            //Check if userinput is bigger as 50. 
            Console.WriteLine("Please enter a number");
            float UserInput = float.Parse(Console.ReadLine());
            bool isGreater = UserInput > 50;
            Console.WriteLine(UserInput + " is greater as 50 = " + isGreater);

            //Divide user input by 7 and prints remainder to the screen.
            Console.WriteLine("Please enter a number");
            float number4 = float.Parse(Console.ReadLine());
            float remainder = number4 % 7;
            Console.WriteLine("The remainder of " + number4 + " : 7 = " + remainder);

            Console.WriteLine("Thanks for using the app! \nPress any key to close the console.");
            Console.Read();
        }
    }
}
