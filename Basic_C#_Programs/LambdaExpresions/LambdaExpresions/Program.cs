using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpresions
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { Id = 1000, FName = "Joe", LName = "Davidson" };
            Employee employee2 = new Employee() { Id = 1001, FName = "Eva", LName = "Brown" };
            Employee employee3 = new Employee() { Id = 1002, FName = "Joe", LName = "Johnson" };
            Employee employee4 = new Employee() { Id = 1003, FName = "Albert", LName = "Davies" };
            Employee employee5 = new Employee() { Id = 1004, FName = "David", LName = "Williams" };
            Employee employee6 = new Employee() { Id = 1005, FName = "Joe", LName = "Smith" };
            Employee employee7 = new Employee() { Id = 1006, FName = "Ester", LName = "Adam" };
            Employee employee8 = new Employee() { Id = 1007, FName = "Anna", LName = "Clarke" };
            Employee employee9 = new Employee() { Id = 1008, FName = "Jesse", LName = "Walker" };
            Employee employee10 = new Employee() { Id = 1009, FName = "Joe", LName = "Thompson" };


            List<Employee> employees = new List<Employee>()
            {
                employee1,
                employee2,
                employee3,
                employee4,
                employee5,
                employee6,
                employee7,
                employee8,
                employee9,
                employee10
            };

            //List<Employee> newList = new List<Employee>();
            //foreach(Employee employee in employees)
            //{
            //    if(employee.FName == "Joe")
            //    {
            //        newList.Add(employee);
            //    }
            //}

            List<Employee> newList = employees.Where(x => x.FName == "Joe").ToList();
            List<Employee> newList2 = employees.Where(x => x.Id > 1005).ToList();

            foreach (Employee employee in newList)
            {
                Console.WriteLine(employee.FName);
            }

            foreach (Employee employee in newList2)
            {
                Console.WriteLine(employee.Id + " " + employee.FName);
            }




            Console.ReadLine();
        }
    }
}
