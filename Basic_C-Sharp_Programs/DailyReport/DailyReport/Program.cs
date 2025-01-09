using System;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            string name;
            string currentCourse;
            int currentPageNumber;
            bool needsHelp;
            string positiveExperiences;
            string otherFeedback;
            int AmountOfHours;

            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("--------------------");
            
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            currentCourse = Console.ReadLine();

            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            currentPageNumber = Convert.ToInt32(pageNumber);

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string help = Console.ReadLine();
            needsHelp = Convert.ToBoolean(help);

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            positiveExperiences = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            otherFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            AmountOfHours = Convert.ToInt32(hours);

            Console.WriteLine("\nThank you for your answers. \nAn Instructor will respond to this shortly. \nHave a great day!” This is the end of the program.");
            Console.WriteLine("Press any key to close the application");
            Console.Read();
        }
    }
}
