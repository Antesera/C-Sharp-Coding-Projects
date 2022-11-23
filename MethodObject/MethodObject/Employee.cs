using System;
using System.Collections.Generic;
using System.Text;

namespace MethodObject
{
    public class Employee : Person
    {
        public int ID { get; set; }

        public int Id()
        {
            return ID;
        }
    }
}
