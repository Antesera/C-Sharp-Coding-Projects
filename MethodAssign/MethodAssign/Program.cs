using System;
using System.Collections.Generic;
using System.Linq;

namespace MethodAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            AssigClass s1 = new AssigClass("Tom", 15, 75);
            s1.Name = "";
            Console.WriteLine(s1.Name);
            s1.FinalGrade = 105;
            Console.WriteLine(s1.FinalGrade);
      
        }
    }
}
