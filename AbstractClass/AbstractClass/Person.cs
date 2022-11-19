using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        
        public virtual void SayName()
        {
            Console.WriteLine("Hi, I'm " + string.Format("{0} {1}", firstName, lastName));
        }
    }
}
