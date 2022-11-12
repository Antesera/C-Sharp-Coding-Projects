using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Parameter MyObject = new Parameter();

            //MyObject.value1 = 4;
            //MyObject.value2 = 8;
            //MyObject.MethodClass();
            Console.WriteLine(MyObject.MethodClass(5, 9, 11));
            Console.ReadLine();
        }
    }
}
