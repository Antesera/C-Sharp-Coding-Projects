using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodObject
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }       

        public void SayName()
        {
            //return "Name:" + FirstName + LastName;
            Console.WriteLine("Name:" + FirstName + LastName);
        }      
       
    }

}

