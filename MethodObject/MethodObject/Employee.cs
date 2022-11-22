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

        internal bool SayName(string v)
        {
            throw new NotImplementedException();
        }
    }
}
