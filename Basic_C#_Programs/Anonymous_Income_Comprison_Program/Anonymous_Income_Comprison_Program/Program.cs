using System;


namespace Anonymous_Income_Comprison_Program
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Please enter the hourly rate, from person 1");
            decimal person1_HourlyRate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Please enter the worked hours per week, from person 1");
            decimal person1_WeekHours = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\nPerson 2");
            Console.WriteLine("Please enter the hourly rate, from person 2");
            decimal person2_HourlyRate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Please enter the worked hours per week, from person 2");
            decimal person2_WeekHours = Convert.ToDecimal(Console.ReadLine());

            // to get the annual salary we multiply the HourlyRate by the WeekHours divide it by 5(days a week) and multyply that with an average of 250 work days.
            decimal person1_AnnualSalary = person1_HourlyRate * person1_WeekHours / 5 * 250;
            decimal person2_AnnualSalary = person2_HourlyRate * person2_WeekHours / 5 * 250;

            Console.WriteLine("\nAnnual salary of Person 1: \n" + person1_AnnualSalary);
            Console.WriteLine("Annual salary of Person 2: \n" + person2_AnnualSalary);

            bool isMore = person1_AnnualSalary > person2_AnnualSalary;
            Console.WriteLine("\nDoes Person 1 make more money than Person 2? \n" + isMore);

            Console.ReadLine();
        }
    }
}
