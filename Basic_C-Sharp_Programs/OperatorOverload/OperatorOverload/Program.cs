using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee_1 = new Employee() { Id = 10012443, Name = "James" };
            Employee employee_2 = new Employee() { Id = 10012443, Name = "Davidson" };
            Employee employee_3 = new Employee() { Id = 10012444, Name = "Eva" };

            // Using a operator == override to compare employees by Employee.Id  
            bool isEqual = employee_1 == employee_2;
            Console.WriteLine(isEqual);
            isEqual = employee_1 == employee_3;
            Console.WriteLine(isEqual);
            Console.ReadLine();

        }
    }
}
