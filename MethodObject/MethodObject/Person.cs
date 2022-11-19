using System;
using System.Collections.Generic;
using System.Text;

namespace MethodObject
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public string GetFullName()
        {
            return FirstName + "" + LastName;
        }
    }
}
