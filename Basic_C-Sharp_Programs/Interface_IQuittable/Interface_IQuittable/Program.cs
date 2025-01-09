using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_IQuittable
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employeeOne = new Employee() { fName = "James", lName = "Davidson" };
            // use Polimorphism to morph Employee into IQuittable.
            IQuittable employeeTwo = new Employee() { fName = "Jesse", lName = "Jones" };

            employeeOne.Quit();
            employeeTwo.Quit();
            Console.ReadLine();
        }
    }
}
