using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Class
 {   
    public class Employee<T>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<T> Things { get; set; }
    }
}
