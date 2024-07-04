using System;
using System.Collections.Generic;

namespace ChooseFromArrayAndList
{
    class Program
    {
        static void Main()
        {
            string[] stringArray = { "This is item 1", "This is item 2", "This is item 3", "This is item 4", "This is item 5"};
            int[] intArray = { 100, 200, 300, 400, 500 };

            List<String> stringList = new List<string>();

            stringList.Add("ListItem 1");
            stringList.Add("ListItem 2");
            stringList.Add("ListItem 3");
            stringList.Add("ListItem 4");
            stringList.Add("ListItem 5");


            Console.WriteLine("Choose a number from the string array index. (0 - 4)");
            int stringIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(stringArray[stringIndex]);

            Console.WriteLine("Choose a number from the interger array index. (0 - 4)");
            int intIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(intArray[intIndex]);

            Console.WriteLine("Choose a number from the string list index. (0 - 4)");
            int listIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(stringList[listIndex]);

            Console.Read();
        }
    }
}
