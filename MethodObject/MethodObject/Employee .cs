using System;
using System.Collections.Generic;
using System.Text;

namespace MethodObject
{
    public class Employee
    {
       public String FirstName { get; set; }
       public string LastName { get; set;}
       public int  ID { get; set;}


        public string GetFullName()
        {
            return FirstName + "" + LastName;
        }
        public int iD()
        {
            return ID;
        }       
    }
}
