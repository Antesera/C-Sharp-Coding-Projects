using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMaths
{
    class Program
    {
        static void Main(string[] args)
        {
            MathClass1 Class1 = new MathClass1();

            Class1.FirstNumber = 10;
            Class1.secondNumber = 5;

            Console.WriteLine(Class1.Multiple().ToString());
            Console.WriteLine(Class1.Addition().ToString());
            Console.WriteLine("Divide Result: " + Class1.Divide());
        }
    }
}
