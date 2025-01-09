using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee_1 = new Employee<string>();
            Employee<int> employee_2 = new Employee<int>();

            employee_1.Things = new List<string>() { "apple", "laptop", "backpack" };
            employee_2.Things = new List<int>() { 1, 5, 5, 7 };

            WriteThings(employee_1);
            WriteThings(employee_2);

            Console.ReadLine();

            void WriteThings<T>(Employee<T> employee)
            {

                foreach(T thing in employee.Things)
                {
                    Console.WriteLine(thing);
                }
                
            }

        }
    }
}
