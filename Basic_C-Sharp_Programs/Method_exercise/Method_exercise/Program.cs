using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using Class Divide\\
            //Instantiate an inctance of class Divide.
            Divide divide = new Divide();

            Console.WriteLine("Enter a number.");
            //Call the function ByTo() on the inctance divide
            //Get a input vrom the user and passes it as parameter.  
            divide.ByTwo(Convert.ToInt32(Console.ReadLine()));
            
            //Print the resuld of divide.ByTwo() to the console.
            Console.WriteLine(divide.result);

            //Using SumOfList()\\
            //Bool to break the while loop.
            bool isLooped = true;
            //List to store user inputted numbers.
            List<int> userValues = new List<int>();
            //Stores homany fives there are in usersValues.
            int Fives;

            //Get user input.
            while(isLooped)
            {
                Console.WriteLine("Enter a number. between 1 and 10");
                //Add the inputted number to the list.
                userValues.Add(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("Do you want to enter another number? \nIf not type NO else press enter to continue");
                //If NO or no is entered the loop breaks if not the user wil be asked to enter another number.
                string stopLoop = Console.ReadLine().ToLower();
                Console.WriteLine(stopLoop);
                //Breaks the loop if no was entered.
                if(stopLoop == "no")
                {
                    isLooped = false;
                }
            }

            //call SumOfList() and stores resuld in resultList and stores the amount of fives in Fives.
            int resultList = SumOfList(userValues: userValues, amountOfFives: out Fives);
            Console.WriteLine("the sum of the entered numbers is: {0} \nYou entered {1} times a 5", resultList, Fives);

            Console.ReadLine();
        }

        
        static int SumOfList(List<int> userValues, out int amountOfFives)
        {
            amountOfFives = 0;
            int sum = 0;

            foreach(int userValue in userValues)
            {
                //Increases amount of fives for each 5 in the list.
                if(userValue == 5)
                {
                    amountOfFives++;
                }
                //Counts the sum of al intergers in the list.
                sum += userValue;
            }

            return sum;
        }


    }
}
