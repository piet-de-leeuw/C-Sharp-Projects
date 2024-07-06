using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_exercise
{
    public class Divide
    {
        //Stores the result of ByTwo.
        public int result;
        
        //This function applys to the instance of this class it is called on.
        //Example: divide.ByTwo() apllys on the instance divide.
        
        public void ByTwo(int userValue)
        {
           //Divides the parameter by two. and stores the result in the property Divide.result of the inctance the method was called on.
           result = userValue /= 2;
        }
    }
}
