using System;
using System.Collections.Generic;
using System.Linq;

namespace MethodAssign
{
    class Program
    {
        //private static string num1;
        //private static string num2;

        static void Main(string[] args)
        {
            MethodAssign.Assig X = new MethodAssign.Assig();
            X.Add(num1: 12, num2: 13);

            Console.WriteLine(Add(12, 13));
            Console.WriteLine(Add(12));
        }
    }
}
