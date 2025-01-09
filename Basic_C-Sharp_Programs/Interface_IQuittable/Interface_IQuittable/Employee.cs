using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_IQuittable
{
    class Employee: IQuittable
    {
        public string fName { get; set; }
        public string lName { get; set; }

        public void Quit()
        {
            Console.WriteLine("I {0} {1} here by quit my job", fName, lName);
        }
    }
}
