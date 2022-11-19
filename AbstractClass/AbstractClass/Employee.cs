using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public class Employee : Person
    {
        //An abstract class can choose to implement methods or leave it the derive class
        public virtual void SayName()
        {
            Console.WriteLine("Hi, I'm " + string.Format("{0} {1}", firstName, lastName));
        }
    }
}
