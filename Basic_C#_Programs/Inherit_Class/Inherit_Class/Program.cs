using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { Id = 1001, FirstName = "Sample", LastName = "Student" };

            //Call Superfunction 
            employee.SayName();
            Console.WriteLine(employee.Id);
            Console.ReadLine();
        }
    }
}
