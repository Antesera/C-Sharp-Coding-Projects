using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    class Program
    {
        public static void Main()
        {

            var my = new Employee();
            my.firstName = "Sample" ;
            my.lastName = "Student" ;
            my.SayName(); 
        }
    }
}
