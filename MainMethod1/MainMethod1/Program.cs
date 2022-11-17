using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainMethod1
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMethod1.seraClass1  Math = new MainMethod1.seraClass1();

            Math.WhoAmI("Ante");

            Console.WriteLine(value: Math.addMe(3, 8));
            Console.WriteLine(value: Math.addMe(3, 8, 4));
            

        }
    }
}
