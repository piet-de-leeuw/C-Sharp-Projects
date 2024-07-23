using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{   
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }



        public static bool operator ==(Employee employee_1, Employee employee_2)
        {
            bool isEqual = employee_1.Id == employee_2.Id;
            return isEqual;
        }
        public static bool operator !=(Employee employee_1, Employee employee_2)
        {
            bool isEqual = employee_1 != employee_2;
            return isEqual;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
